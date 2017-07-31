using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LibraryUI
{
    public partial class UIlanding : Form
    {
        public UIlanding()
        {
            InitializeComponent();
        }

        bool level;
        private LibraryModel.user_Param userParam;
        static byte[] b;
        private void UIlanding_Load(object sender, EventArgs e) //窗体开启时用户名输入框获取焦点
        {
            user.Focus();
        }

        private void cancle_Click(object sender, EventArgs e) //取消键按下事件
        {
            user.Text = "";
            password.Text = "";
            this.Close();
        }

        private void login_Click(object sender, EventArgs e) //注册键按下事件
        {
            UIlogin login = new UIlogin();
            login.Show();
        }

        private void land_Click(object sender, EventArgs e) //登陆检测与传参
        {
            SqlDataReader landing;
            try
            {
                landing = LibraryBLL.user.land(user.Text,password.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if(landing["level"].ToString().Trim()=="True") //判断登陆权限
            {
                level = true;
            }
            else
            {
                level = false;
            }
            LibraryModel.userParam.name = landing["name"].ToString();
            LibraryModel.userParam.level = level;
            LibraryModel.userParam.headpath = b;
            this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
            this.Close();    //关闭登录窗口
        }

        private void user_TextChanged(object sender, EventArgs e) //动态显示头像
        {
            LibraryBLL.landingcheck check=new LibraryBLL.landingcheck();
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
                head.BackgroundImage = LibraryBLL.drawimag.headima(ima,head.Width,head.Height);
            }
        }

        private void head_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circle_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
