using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryModel;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace LibraryUI_rebuild
{
    public partial class UImain : CCSkinMain
    {
        #region 变量

        private bool level=false;//权限
        private string name;//姓名
        private string stu_name;//学生姓名
        private int qusertionId=0;
        private int pagelast = 0;//上一次点击的页面
        private user_Param userParam; //用户数据缓存
        private book_Param bookParam; //书本数据缓存
        private Image headimg; //头像
        private string filename = "";
        private string filepath = "";
        private int SW; 
        private int SH;
        private bool l = false;
        UIheadchange headchange;
        FileInfo fileinfo;
        UIbookchange bookchange;
        

        #endregion

        #region 构造

        public UImain()
        {
            InitializeComponent();
        }

        #endregion

        #region 带参构造

        public UImain(user_Param userParam)
            : this()
        {
            Helper.eventSend += new SendHandler(ReceiveParam);
            /**New一个当前用户的对象
            UserItem = new ChatListSubItem(userParam.Id, (ChatListSubItem.UserStatus)Convert.ToInt32(userParam.BtnState.Tag));
            UserItem.HeadImage = userParam.HeadImg;
            UserItem.PersonalMsg = lblQm.Text;
            UserLogin.UserItem = UserItem;**/
            //获取当前登录帐号与头像
            this.stu_name = nameshow.Text = userParam.stuname;
            this.headimg = head.BackgroundImage=userParam.HeadImg;
            this.level = userParam.level;
            lastOnline.Text = userParam.lastonline;
            /**获取当前状态
            btnState.Image = userParam.BtnState.Image;
            btnState.Tag = userParam.BtnState.Tag;
            btnState.Left = lblName.Right;
            lblLv.Left = btnState.Right;**/
            //获取屏幕宽高
            SW = Screen.PrimaryScreen.Bounds.Width;
            SH = Screen.PrimaryScreen.Bounds.Height;

            /**
            this.userParam = userParam;
            if (userParam.BackImg != null)
            {
                this.Back = userParam.BackImg;
                this.btnTq.Image = userParam.WeatherImg;
            }**/
            //else
            //{
            //    btnTq.Visible = false;
            //}

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
                    case eFrom.Show_headchange:
                        Showheadchange(sender as user_Param);
                        break;
                    case eFrom.Show_bookchange:
                        Showbookchange(sender as book_Param);
                        break;
                }
            }
        }

        #endregion

        #region 窗体加载

        private void UImain_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“db_libaryDataSet3.tb_question”中。您可以根据需要移动或删除它。
            this.tb_questionTableAdapter1.Fill(this.db_libaryDataSet3.tb_question);
            // TODO:  这行代码将数据加载到表“db_libaryDataSet1.tb_question”中。您可以根据需要移动或删除它。
            this.tb_questionTableAdapter.Fill(this.db_libaryDataSet1.tb_question);
            // TODO:  这行代码将数据加载到表“db_libaryDataSet.tb_User”中。
            this.tb_UserTableAdapter.Fill(this.db_libaryDataSet.tb_User);
            // TODO:  这行代码将数据加载到表“db_libaryDataSet.tb_book”中。
            this.tb_bookTableAdapter.Fill(this.db_libaryDataSet.tb_book);
            groundchange();
            main.SelectedIndex = 0;
            rootcontrol.SelectedIndex = 0;
            firstpageitem.SelectedIndex = 0;
            booksearchtype.SelectedIndex = 0;
            bookinfoshow("","");
            bookshow("", "");
            askContentshow("");
            userinfoshow();
            landusershow();
            landuserpicshow();
            skinPanel7.Hide();
        }

        #endregion

        #region 用户信息页界面

        public void landusershow()//登录用户信息显示
        {
            SqlDataReader landerinfo;
            try
            {
                landerinfo = LibraryBLL.user.lander(nameshow.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            username.Text = landerinfo["name"].ToString();
            userid.Text = landerinfo["student_id"].ToString();
            phone.Text = landerinfo["phone"].ToString();
            qq.Text = landerinfo["qq"].ToString();
            personalSign.Text = landerinfo["signature"].ToString();
            if (landerinfo["level"].ToString().Trim() == "True") 
            {
                leveltext.Text = "管理员";
            }
            else
            {
                leveltext.Text = "普通用户";
            }
            
        }
        public void landuserpicshow() //用户头像显示
        {
            byte[] b;
            LibraryBLL.user check = new LibraryBLL.user();
            try
            {
                b = check.image(username.Text);
            }
            catch
            {
                head.BackgroundImage = null;
                return;
            }
            if (b.Length > 0)
            {
                try
                {
                    byte[] ima = b;
                    head.BackgroundImage = LibraryBLL.drawimag.headima(ima, head.Width, head.Height);
                }
                catch
                {
                    head.BackgroundImage = null;

                    return;
                }
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //更换头像
        {
            userParam = new LibraryModel.user_Param();
            userParam.name = nameshow.Text;
            userParam.HeadImg = head.BackgroundImage;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(GetuserLog), nameshow.Text);
        }

        private void GetuserLog(object o)
        {
            Helper.SendMessage(userParam, eFrom.Show_headchange);
        }


        private void uerInformChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//修改当前用户信息
        {
            userNameChange.WaterText =userNameChange.Text=username.Text;userNameChange.Visible = true;
            phoneChange.WaterText = phoneChange.Text = phone.Text; phoneChange.Visible = true;
            qqChange.WaterText = qqChange.Text = qq.Text; qqChange.Visible = true;
            userInfoSure.Visible = true;
            userInfoCancle.Visible = true;
            personalSign.ReadOnly=false;personalSign.WaterText=personalSign.Text;personalSign.Text="";
        }

        private void userInfoCancle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//取消更改
        {
            userNameChange.Visible = false; userNameChange.WaterText = "";
            phoneChange.Visible = false; phoneChange.WaterText = "";
            qqChange.Visible = false; qqChange.WaterText = "";
            userInfoSure.Visible = false;
            userInfoCancle.Visible = false;
            personalSign.ReadOnly = true; personalSign.Text = personalSign.WaterText; personalSign.WaterText = "";
            landusershow();
        }

        private void userInfoSure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//上传修改更新
        {
            string nameChange,phonechange,qqchange,personalSignChange;
            nameChange = userNameChange.Text;
            phonechange = phoneChange.Text;
            qqchange = qqChange.Text;
            personalSignChange=personalSign.Text;
            LibraryBLL.user operate= new LibraryBLL.user();
            try
            {
                operate.userInfochange(nameChange, phonechange, qqchange, personalSignChange, stu_name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("更改成功");
            userNameChange.Visible = false; userNameChange.WaterText = "";
            phoneChange.Visible = false; phoneChange.WaterText = "";
            qqChange.Visible = false; qqChange.WaterText = "";
            userInfoSure.Visible = false;
            userInfoCancle.Visible = false;
            personalSign.ReadOnly = true; personalSign.WaterText = "";
            landusershow();
        }


        private string questName(int Id)//问题标题
        {
            string qname = ""; SqlDataReader questname;
            try
            {
                questname = LibraryBLL.question.questionname(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return qname;
            }
            qname = questname["title"].ToString().Trim();
            return qname;
        }

        public void answerRemindShow()//回复提醒
        {
            this.answerRemindPanel.Controls.Clear();
            SqlDataReader answerremind; string commenter; int i = 1;
            string time = System.DateTime.Now.ToString();
            try
            {
                answerremind = LibraryBLL.user.answerremind(time);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            while (answerremind.Read())
            {
                int k = (int)answerremind["qusetionId"];
                LibraryModel.anser_Remind answerComment = new anser_Remind();
                answerComment.answername = answerremind["answerName"].ToString().Trim();
                answerComment.answerdate = answerremind["answertime"].ToString();
                answerComment.questionname = questName(k);
                LibrarySET.anserRemindShow UIcomment = new LibrarySET.anserRemindShow(answerComment);
                UIcomment.Click += new EventHandler(this.answerContent_Click);
                this.answerRemindPanel.Controls.Add(UIcomment);
            }
        }

        private void answerContent_Click(object sender, EventArgs e)//跳转详细
        {
            string titlename;
            main.SelectedIndex = 2;
            LibrarySET.anserRemindShow myquestion = (LibrarySET.anserRemindShow)sender;
            titlename = myquestion.Name;
            contentMainShow(titlename);
        }

        #endregion

        #region 书本展示界面
        private void covershow(string name)//封面显示
        {
            byte[] b;
            LibraryBLL.book show = new LibraryBLL.book();
            try
            {
                b = show.covershow(name);
            }
            catch
            {
                bookPicture.BackgroundImage = null;
                return;
            }
            if (b.Length > 0)
            {
                try
                {
                    byte[] ima = b;
                    bookPicture.BackgroundImage = LibraryBLL.drawimag.headima(ima, bookPicture.Width, bookPicture.Height);
                }
                catch
                {
                    bookPicture.BackgroundImage = null;
                    return;
                }
            }
        }
        public void bookshow(string code, string value)//书本列表刷新
        {
            SqlDataReader bookinfo;
            try
            {
                bookinfo = LibraryBLL.book.bookshowswitch(code, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = bookinfo;
            booklist.DataSource = bs;
        }
        

        private void booklistsearch_Click(object sender, EventArgs e)//书本搜索
        {
            string searchtype = booktype.Text;
            string bookkeyword = booksearch.Text;
            bookshow(searchtype, bookkeyword);
        }

        public void bookcommentshow(string name)//书评显示
        {
            this.commentList.Controls.Clear();
            SqlDataReader bookcomment; string commenter; int i=1;
            try
            {
                bookcomment = LibraryBLL.book.bookcommentdata(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            while(bookcomment.Read())
            {
                commenter = bookcomment["commenter"].ToString().Trim();
                LibraryModel.book_Comment bookComment = new book_Comment();
                bookComment.name = commenter;
                bookComment.comment = bookcomment["comment"].ToString();
                bookComment.date = bookcomment["date"].ToString();
                bookComment.commenterImg = img(commenter);
                bookComment.floor = i.ToString(); i++;
                LibrarySET.bookcomment UIcomment = new LibrarySET.bookcomment(bookComment);
                this.commentList.Controls.Add(UIcomment);
            }
        }

        private Image img(string name) //传输头像
        {
            byte[] b; Image image;
            LibraryBLL.user check = new LibraryBLL.user();
            try
            {
                b = check.image(name);
            }
            catch
            {
                image = null;
                return image;
            }
            if (b.Length > 0)
            {
                try
                {
                    byte[] ima = b;
                    image = LibraryBLL.drawimag.headima(ima, head.Width, head.Height);
                }
                catch
                {
                    image = null;
                    return image;
                }

                return image;
            }
            else
            {
                image = null;
                return image;
            }
        }      
        private void booklist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//双击显示详情
        {
            int i = booklist.CurrentRow.Index;
            string bookname = booklist.Rows[i].Cells[0].Value.ToString();
            SqlDataReader bookinfo;
            try
            {
                bookinfo = LibraryBLL.book.bookshowswitch("书名", bookname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            bookinfo.Read();
            bookName.Text = bookinfo["name"].ToString();
            bookauthor.Text = bookinfo["autor"].ToString();
            bookPubname.Text = bookinfo["pubname"].ToString();
            booksorted.Text = bookinfo["type"].ToString();
            bookpage.Text = bookinfo["pagecode"].ToString();
            bookprice.Text = bookinfo["price"].ToString() + "元";
            bookdate.Text = bookinfo["date"].ToString();
            bookIntro.Text = bookinfo["about"].ToString();
            covershow(bookname);
            bookcommentshow(bookname);
        }


        private void skinButton3_Click(object sender, EventArgs e)//刷新
        {
            bookshow("", "");
        }


        private void commentUpload_Click(object sender, EventArgs e)//发布评论
        {
            string time = System.DateTime.Now.ToString();
            string nameUpload = username.Text;
            string bookname = bookName.Text;
            string comment = commentText.Text;
            if (comment == null)
            {
                return;
            }
            LibraryBLL.book bookupdate = new LibraryBLL.book();
            try
            {
                bookupdate.bookCommentCheckIn(bookname, nameUpload, time, comment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (MessageBox.Show("评论成功") == DialogResult.OK)
            {
                bookcommentshow(bookname);
            }
        }


        #endregion

        #region 问题展示与发布

        public void askContentshow(string type)//问题显示
        {
            this.ask_Content.Controls.Clear();
            SqlDataReader askContent;
            if(type == "")
            {
                try
                {
                    askContent = LibraryBLL.question.askContent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    askContent = LibraryBLL.question.askContent(type);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            while (askContent.Read())
            {
                LibraryModel.ask_Content askContentdate = new ask_Content();
                askContentdate.name = askContent["questionerId"].ToString();
                askContentdate.type= askContent["type"].ToString();
                askContentdate.date = askContent["uploadTime"].ToString();
                askContentdate.contentImg = img(askContentdate.name);
                askContentdate.title = askContent["title"].ToString();
                LibrarySET.questionSample UIcomment = new LibrarySET.questionSample(askContentdate);
                UIcomment.Click += new EventHandler(this.askContent_Click);
                this.ask_Content.Controls.Add(UIcomment);
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)//分类显示
        {
            string type = questionlistType.Text;
            askContentshow(type);
        }

        private void  contentMainShow(string title)//详情展示
        {
            SqlDataReader contentMain;
            try
            {
                contentMain = LibraryBLL.question.conentmainshow(title);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            contenttitle.Text = contentMain["title"].ToString();
            qusertionId = (int)contentMain["id"];
            questioner.Text = contentMain["questionerId"].ToString();
            questiondate.Text = contentMain["uploadTime"].ToString();
            contentword.Text = contentMain["about"].ToString();
            fileName.Text = contentMain["filename"].ToString();
            if (fileName.Text.Trim() != "")
            {
                linkLabel2.Visible = true;
            }
            else
            {
                linkLabel2.Visible = false;
            }
            Typeword.Text ="#"+contentMain["type"].ToString().Trim() + "#";
            questionerImg.BackgroundImage = img(questioner.Text);
            answerContentshow();
        }

        private void askContent_Click(object sender, EventArgs e)//获取标题
        {
            string titlename;
            LibrarySET.questionSample myquestion = (LibrarySET.questionSample)sender;
            titlename = myquestion.Name;
            contentMainShow(titlename);
        }

        private void chooseQusetionFile_Click(object sender, EventArgs e)//选择文件
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = openFileDialog.FileNames.ToString();
            openFileDialog.Filter = "所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            questionLoad.Text = filepath = openFileDialog.FileName;
            filename = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName) + "." + System.IO.Path.GetExtension(openFileDialog.FileName);
        }

        private void questionUpload_Click(object sender, EventArgs e)//问题上传
        { 
            try
            {
                LibraryBLL.question a = new LibraryBLL.question();
                a.questionCheckIn(questionTitle.Text, questionType.Text, questionIntro.Text, filename, System.DateTime.Now.ToString(), username.Text);
                LibraryBLL.FtpHelper b = new LibraryBLL.FtpHelper();
                if(filename != "")
                b.Upload(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (MessageBox.Show("发布成功") == DialogResult.OK)
            {
                askContentshow("");
                filename = ""; filepath = "";
                skinPanelQuestion.Visible = false;
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//下载文件
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName.Text.Trim();
            saveFileDialog.Filter = "所有文件(*.*)|(*.*)";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filePath = saveFileDialog.FileName;
            try
            {
                LibraryBLL.FtpHelper b = new LibraryBLL.FtpHelper();
                b.Download(filePath, fileName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("下载成功");
        }

        public void answerContentshow()//回答显示
        {
            this.answer_Content.Controls.Clear();
            SqlDataReader answerContent;int i=1;
            try
            {
                answerContent = LibraryBLL.question.answerContent(qusertionId);
             }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            while (answerContent.Read())
            {
                LibraryModel.answer_Content answerContentdate = new answer_Content();
                answerContentdate.name = answerContent["answerName"].ToString();
                answerContentdate.content = answerContent["intro"].ToString();
                answerContentdate.date = answerContent["answertime"].ToString();
                answerContentdate.contentImg = img(answerContentdate.name);
                answerContentdate.fileName = answerContent["fileName"].ToString();
                answerContentdate.floor = i.ToString(); i++;
                LibrarySET.answerSample UIcomment = new LibrarySET.answerSample(answerContentdate);
                this.answer_Content.Controls.Add(UIcomment);
            }
        }

        private void chooseAnswerFile_Click(object sender, EventArgs e)//选择文件
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = openFileDialog.FileNames.ToString();
            openFileDialog.Filter = "所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            answerLoad.Text = filepath = openFileDialog.FileName;
            filename = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName) + System.IO.Path.GetExtension(openFileDialog.FileName);
        }

        private void answerUpload_Click(object sender, EventArgs e)//回答上传
        {
            try
            {
                LibraryBLL.question a = new LibraryBLL.question();
                a.answerCheckIn(answerIntro.Text, qusertionId, username.Text, System.DateTime.Now.ToString(), filename);
                LibraryBLL.FtpHelper b = new LibraryBLL.FtpHelper();
                if(filename != "")
                {
                    b.answerUpload(filepath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (MessageBox.Show("发布成功") == DialogResult.OK)
            {
                answerContentshow();
                filename = ""; filepath = "";
            }
        }


        #endregion

        #region 管理员页面刷新

        private void rootcontrol_Selected(object sender, TabControlEventArgs e)//选项卡连接数据库
        {
            switch (rootcontrol.SelectedIndex)
            {
                case 0:
                    bookinfoshow("","");
                    break;
                case 1:
                    break;
                case 2:
                    userinfoshow();
                    break;

            }
        }

        #endregion

        #region 书本管理界面

        public void bookinfoshow(string code, string value)//书本列表刷新
        {
            SqlDataReader bookinfo;
            try
            {
                bookinfo = LibraryBLL.book.bookshowswitch(code, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = bookinfo;
            bookinfolist.DataSource = bs;
        }

        private void search_Click(object sender, EventArgs e)//查询书目
        {
            string searchtype = booksearchtype.Text;
            string bookkeyword = bookmanagekey.Text;
            bookinfoshow(searchtype, bookkeyword);
        }

        private void bookdelet_Click(object sender, EventArgs e)//书本信息删除
        {
            int a = 0; string b = ""; ArrayList bookname = new ArrayList();
            for (int i = 0; i < bookinfolist.RowCount; i++)
            {
                DataGridViewCell bookselect = (DataGridViewCell)bookinfolist.Rows[i].Cells[0];
                if ((string)bookselect.Value == "True")
                {
                    b = bookinfolist.Rows[i].Cells[8].Value.ToString();
                    bookname.Add(b);
                }
            }
            if (MessageBox.Show("确定删除" + bookname.Count + "条数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                LibraryBLL.book book = new LibraryBLL.book();
                try
                {
                    a = book.bookdelete(bookname);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                bookinfoshow("", "");
                MessageBox.Show("删除了" + a + "条数据");
            }
        }

        private void bookrefrsh_Click(object sender, EventArgs e)//刷新页面
        {
            bookinfoshow("","");
        }

        private void bookinfolist_CellContentClick(object sender, DataGridViewCellEventArgs e)//修改书本信息
        {
            DataGridViewColumn column = bookinfolist.Columns[e.ColumnIndex];
            int i = bookinfolist.CurrentRow.Index;
            if (column is DataGridViewButtonColumn)
            {
                string bookcode = bookinfolist.Rows[i].Cells[2].Value.ToString();
                bookParam = new LibraryModel.book_Param();
                bookParam.code = bookcode;
                System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(GetbookLog), bookcode);
            }
        }

        private void GetbookLog(object o)
        {
            Helper.SendMessage(bookParam, eFrom.Show_bookchange);
        }

        private void bookadd_Click(object sender, EventArgs e)//新增书本
        {
            UIbookadd bookadd = new UIbookadd();
            bookadd.ShowDialog();
        }

        #endregion

        #region 用户管理页面

        private void fresh_Click(object sender, EventArgs e)//刷新
        {
            userinfoshow();
        }

        private void adduser_Click(object sender, EventArgs e)//增加用户
        {
            UIlogin login = new UIlogin();
            login.ShowDialog();

        }

        private void userinfolist_CellContentClick(object sender, DataGridViewCellEventArgs e)//权限变更
        {
            DataGridViewColumn column = userinfolist.Columns[e.ColumnIndex];
            int i = userinfolist.CurrentRow.Index;
            if (column is DataGridViewButtonColumn)
            {
                string s = userinfolist.Rows[i].Cells[2].Value.ToString();
                string b = userinfolist.Rows[i].Cells[8].Value.ToString();
                LibraryBLL.user levelchange = new LibraryBLL.user();
                try
                {
                    levelchange.levelchange(s, b);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("权限更新成功");
                userinfoshow();
            }
        }

        public void userinfoshow()//用户列表刷新
        {
            SqlDataReader userinfo;
            try
            {
                userinfo = LibraryBLL.user.userinfodata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = userinfo;
            userinfolist.DataSource = bs;
        }

        private void deletuser_Click(object sender, EventArgs e)//删除用户
        {
            int a = 0; ArrayList name = new ArrayList();
            for (int i = 0; i < userinfolist.RowCount; i++)
            {
                string b; 
                DataGridViewCell checkbox = (DataGridViewCell)this.userinfolist.Rows[i].Cells[0];
                if ((string)checkbox.Value == "True")
                {
                    b = userinfolist.Rows[i].Cells[2].Value.ToString();
                    name.Add(b);
                }
             }
            if (MessageBox.Show("确定删除" + name.Count + "条数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                LibraryBLL.user user = new LibraryBLL.user();
                try
                {
                    a = user.userdelete(name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                userinfoshow();
                MessageBox.Show("已经删除" + a + "条数据");
            }
        }

        #endregion

        #region 问题管理页面

        private void toolStripButton3_Click(object sender, EventArgs e)//删除提问
        {
            int a = 0; ArrayList name = new ArrayList();
            for (int i = 0; i < questionControlList.RowCount; i++)
            {
                string b, c;
                DataGridViewCell checkbox = (DataGridViewCell)this.questionControlList.Rows[i].Cells[0];
                if ((string)checkbox.Value == "True")
                {
                    b = questionControlList.Rows[i].Cells[1].Value.ToString();
                    name.Add(b);
                }
            }
            if (MessageBox.Show("确定删除" + name.Count + "条数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                LibraryBLL.question comment = new LibraryBLL.question();
                try
                {
                    a = comment.questiondelete(name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("已经删除" + a + "条数据"); ;
            }
        }

        #endregion

        #region 其他

        private void firstpageitem_Selecting(object sender, TabControlCancelEventArgs e)//页面选择
        {
            if (firstpageitem.SelectedIndex == 1)
            {
                answerRemindShow();
            }
        }

        private void main_Selecting(object sender, TabControlCancelEventArgs e)//权限检测
        {
            if (main.SelectedIndex == 3&&level==false)
            {
                MessageBox.Show("你的权限等级不足，请与管理员联系");
                main.SelectedIndex = pagelast;
                return;
            }
            else
            {
                pagelast = main.SelectedIndex;
            }
            switch (main.SelectedIndex)
            {
                case 1:
                    bookshow("","");
                    bookcommentshow(bookName.Text);
                    break;
                case 2:
                    askContentshow("");
                    skinPanelQuestion.Visible = false;
                    skinPanelAnswer.Visible = false;
                    break;
            }
        }

        private void groundchange()//背景色设置
        {
            firstpage.BackColor = Color.FromArgb(50, Color.White);
            bookstore.BackColor = Color.FromArgb(50, Color.White);
            project.BackColor = Color.FromArgb(50, Color.White);
            root.BackColor = Color.FromArgb(50, Color.White);
            main.BackColor = Color.FromArgb(50, Color.Gray);
            rootcontrol.BackColor = Color.FromArgb(50, Color.Gray);
            usermanage.BackColor = Color.FromArgb(50, Color.White);
            project.BackColor = Color.FromArgb(50, Color.White);
            bookmanage.BackColor = Color.FromArgb(50, Color.White);
            userinfo.BackColor = Color.FromArgb(50, Color.White);
            message.BackColor = Color.FromArgb(50, Color.White);
        }

        private void setting_Click(object sender, EventArgs e)//设置菜单动作
        {
            settingmenu.Show(setting,0,setting.Height+3);
        }

        private void UImain_FormClosing(object sender, FormClosingEventArgs e)
        {
            LibraryBLL.user levelchange = new LibraryBLL.user();
            try
            {
                levelchange.offline(stu_name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }


        private void UImain_FormClosed(object sender, FormClosedEventArgs e)//完全退出
        {
            //ClassBoardCast cUserQuit = new ClassBoardCast();
            //cUserQuit.UserQuit();
            //Application.Exit();
            
            System.Environment.Exit(0);
        }

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)//登出
        {
            LibraryBLL.user levelchange = new LibraryBLL.user();
            try
            {
                levelchange.offline(stu_name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UIlanding landing = new UIlanding();
            this.Hide();
            landing.Show();
        }

        private void UImain_Activated(object sender, EventArgs e)//主界面激活刷新
        {
            bookinfoshow("", "");
            userinfoshow();
            landuserpicshow();
            landusershow();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//隐藏显示
        {
            if (!l)
            {
                skinPanel7.Show();
                l = true;
            }
            else
            {
                skinPanel7.Hide();
                l = false;
            }
        }

        private void answershow_Click(object sender, EventArgs e)//回答隐藏显示
        {
            
            if (qusertionId == 0)
                return;
            else
            {
                if (skinPanelAnswer.Visible == false)
                {
                    skinPanelQuestion.Visible = false;
                    skinPanelAnswer.Visible = true;
                }
                else
                {
                    skinPanelQuestion.Visible = false;
                    skinPanelAnswer.Visible = false;
                }
            }
        }

        private void questionshow_Click(object sender, EventArgs e)//问题隐藏显示
        {
                if (skinPanelQuestion.Visible == false)
                {
                    skinPanelQuestion.Visible = true;
                    skinPanelAnswer.Visible = false;
                }
                else
                {
                    skinPanelQuestion.Visible = false;
                    skinPanelAnswer.Visible = false;
                }
        }

        private void changeUserOnline(string user)
        {

        }
        #endregion

        #region 委托显示窗体

        delegate void ShowMainFrmEventHandler(user_Param userParam);
        private void Showheadchange(user_Param userParam)
        {
            if (this.InvokeRequired)
            {
                ShowMainFrmEventHandler cb = new ShowMainFrmEventHandler(Showheadchange);
                this.Invoke(cb, new object[] { userParam });
            }
            else
            {
                headchange = new UIheadchange(userParam);
                headchange.ShowDialog();
            }

        }

        delegate void ShowBookFrmEventHandler(book_Param bookParam);
        private void Showbookchange(book_Param bookParam)
        {
            if (this.InvokeRequired)
            {
                ShowBookFrmEventHandler cb = new ShowBookFrmEventHandler(Showbookchange);
                this.Invoke(cb, new object[] { bookParam });
            }
            else
            {
                bookchange = new UIbookchange(bookParam);
                bookchange.ShowDialog();
            }

        }
        #endregion

    }
}
