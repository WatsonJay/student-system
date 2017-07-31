using CCWin;
using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using LibraryUI_rebuild.Properties;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryModel;

namespace LibraryUI_rebuild
{
    public partial class UIlanding : CCSkinMain
    {
        #region 变量

        bool level;
        static byte[] b;
        private LibraryModel.user_Param userParam;
        string timer;

        #endregion

        #region 构造

        public UIlanding()
        {
            InitializeComponent();
            //订阅自定义事件
            Helper.eventSend += new SendHandler(ReceiveParam);
        }

        #endregion

        #region 窗口加载
        private void Form1_Load(object sender, EventArgs e) //时段检测
        {
            int H = DateTime.Now.Hour;
            this.Back=
                H > 5 & H <= 11 ? Resources.morningSCO_01 :     //早上
                H > 11 & H <= 15 ? Resources.noonSCO :       //中午
                H > 15 & H <= 18 ? Resources.afternoonSCO :      //下午
                Resources.nightSCO;        //晚上
        }
        #endregion

        #region 监听事件

        void ReceiveParam(object sender, object msg)
        {
            Type t = msg.GetType();
            if (t.IsEnum)
            {
                eFrom e = (eFrom)msg;
                switch (e)
                {
                    case eFrom.Show_Main:
                        ShowMainFrm(sender as user_Param);
                        break;
                }
            }
        }

        #endregion

        #region 注册窗体
        private void skinButton2_Click(object sender, EventArgs e) //注册页面
        {
            UIlogin login = new UIlogin();
            login.ShowDialog();
        }
        #endregion

        #region 登陆窗体
        UImain main;
        private void landing_Click(object sender, EventArgs e) //登陆页面
        {
            SqlDataReader landing;
            try
            {
                landing = LibraryBLL.user.land(user.Text, password.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (landing["level"].ToString().Trim() == "True") //判断登陆权限
            {
                level = true;
            }
            else
            {
                level = false;
            }

            user.Visible = password.Visible = login.Visible = btnlanding.Visible = false;//按键隐藏

            head.Left = (this.Width - head.Width) / 2;//头像居中

            userParam = new LibraryModel.user_Param();
            userParam.HeadImg = head.BackgroundImage;
            userParam.level = level;
            userParam.stuname = landing["student_name"].ToString().Trim();
            userParam.lastonline = landing["onlinedate"].ToString();
            if(landing["online"].ToString().Trim() == "True")
            {
                MessageBox.Show("用户在线，过后重试");
            }
            timer = System.DateTime.Now.ToString();
            LibraryBLL.user levelchange = new LibraryBLL.user();
            try
            {
                levelchange.online(timer, user.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(GetLog), user.SkinTxt.Text);
        }
        #endregion

        #region 获取上次登录与天气信息

        private void GetLog(object o)
        {
       /*** try
            {
                string loginId = o as string;
                string showText = string.Empty;
                IpStat ipStat = null;
                XmlDocument doc = new XmlDocument();
                doc.Load(logXmlPath);
                XmlNodeList dateData = doc.DocumentElement.ChildNodes;
                bool flag = false; //标识是否找到帐号 
                foreach (XmlNode subNode in dateData)
                {
                    if (loginId == subNode.Attributes["id"].Value)
                    {
                        flag = true;
                        ipStat = WriteXml(doc, subNode);
                        break;
                    }

                }

                //新用户
                if (!flag)
                {
                    XmlElement node = doc.CreateElement("Info");
                    XmlNode attr = doc.CreateNode(XmlNodeType.Attribute, "id", null);
                    attr.Value = txtId.SkinTxt.Text;
                    node.Attributes.SetNamedItem(attr);

                    attr = doc.CreateNode(XmlNodeType.Attribute, "nickname", null);
                    attr.Value = "新用户";
                    node.Attributes.SetNamedItem(attr);

                    attr = doc.CreateNode(XmlNodeType.Attribute, "text", null);
                    attr.Value = "这家伙很懒，什么都没写。";
                    node.Attributes.SetNamedItem(attr);
                    doc.DocumentElement.AppendChild(node);

                    ipStat = WriteXml(doc, node);
                }

                /***以下二选一***/
                //string[] s = GetWeatherByWebSevice(ipStat); //调用WebService
                //string[] s = GetWeatherByWebSeviceUrl(ipStat); //调用WebServiceURL
                /***End***/

            /***
                if (s != null)
                {
                    WeatherGet.DisWeatherInfo(userParam, s); //分解天气信息与获取背景图
                }
            ***/
                Helper.SendMessage(userParam, eFrom.Show_Main);
            /***
            }
            catch (Exception A)
            {
                Console.WriteLine("Exception: {0}", A.ToString());
            }

            ***/
        }

        #endregion

        #region 委托显示窗体

        delegate void ShowMainFrmEventHandler(user_Param userParam);
        private void ShowMainFrm(user_Param userParam)
        {
            if (this.InvokeRequired)
            {
                ShowMainFrmEventHandler cb = new ShowMainFrmEventHandler(ShowMainFrm);
                this.Invoke(cb, new object[] { userParam });
            }
            else
            {
                this.Hide();
                main = new UImain(userParam);
                main.Show();
            }

        }

        #endregion

        #region 其他
        private void skinTextBox1_Leave(object sender, EventArgs e) //动态头像
        {
            LibraryBLL.user check = new LibraryBLL.user();
            try
            {
                b = check.image(user.Text);
            }
            catch
            {
                head.BackgroundImage = null;
                return;
            }
            if (b.Length > 0)
            {
                byte[] ima = b;
                try
                {
                    head.BackgroundImage = LibraryBLL.drawimag.headima(ima, head.Width, head.Height);
                }
                catch
                {
                    head.BackgroundImage = null;

                    return;
                }
            }
        }

        private void password_IconClick(object sender, EventArgs e) //软键盘
        {
            PassKey pass = new PassKey(this.Left + password.Left - 25, this.Top + password.Bottom, password.SkinTxt);
            pass.Show(this);
        }

        #endregion

    }
}
