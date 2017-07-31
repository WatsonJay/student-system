using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryModel;
using CCWin;
using System.Data.SqlClient;
using System.Collections;


namespace LibraryUI_rebuild
{
    public partial class UIbookchange : CCSkinMain
    {
        #region 变量

        private book_Param bookParam; //用户数据缓存
        private string code;//姓名

        #endregion

        #region 初始化

        public UIbookchange()
        {
            InitializeComponent();
        }

        private void UIbookchange_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“db_libaryDataSet2.tb_bookcomment”中。您可以根据需要移动或删除它。
            this.tb_bookcommentTableAdapter.Fill(this.db_libaryDataSet2.tb_bookcomment);

        }

        #endregion

        #region 带参重构

        public UIbookchange(book_Param bookParam):this()
        {
            this.code =codeword.Text = bookParam.code;
            bookInfoFilled();
            groundchange();
            bookcommentshow();
            skinTabControl1.SelectedIndex = 0;
        }

        #endregion

        #region 书本信息填充

        private void bookInfoFilled()//书本信息填充
        {
            SqlDataReader bookinfo;
            try
            {
                bookinfo = LibraryBLL.book.bookinfodata(code);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            bookname.Text = bookinfo["name"].ToString();
            autor.Text = bookinfo["autor"].ToString();
            pubname.Text = bookinfo["pubname"].ToString();
            type.Text = bookinfo["type"].ToString();
            date.Text = bookinfo["date"].ToString();
            page.Text = bookinfo["pagecode"].ToString();
            bookIntro.Text = bookinfo["about"].ToString();
            textBox1.Text = bookinfo["price"].ToString();
            byte[] b;
            LibraryBLL.book show = new LibraryBLL.book();
            try
            {
                b = show.covershow(bookname.Text);
            }
            catch
            {
                bookimg.BackgroundImage = null;
                return;
            }
            if (b.Length > 0)
            {
                try
                {
                    byte[] ima = b;
                    bookimg.BackgroundImage = LibraryBLL.drawimag.headima(ima, bookimg.Width, bookimg.Height);
                }
                catch
                {
                    bookimg.BackgroundImage = null;
                    return;
                }
            }
        }

        #endregion

        #region 上传更新

        private void sure_Click(object sender, EventArgs e)
        {
            if (bookname.Text == "" || autor.Text == "" || pubname.Text == "" || type.Text == "" || date.Text == "" || page.Text == "" || textBox1.Text == "" || bookIntro.Text == "")
            {
                if (MessageBox.Show("存在字段为空") == DialogResult.OK)
                {
                    return;
                }
            }

            DateTime tm;

            if (false == DateTime.TryParse(date.Text, out tm))
            {
                if (MessageBox.Show("时间格式错误") == DialogResult.OK)
                {
                    return;
                }
            }
            byte[] road = ESBasic.Helpers.ImageHelper.Convert(this.bookimg.BackgroundImage);
            LibraryBLL.book bookupdate=new LibraryBLL.book();
            try
            {
                bookupdate.bookinfochange(bookname.Text, autor.Text, type.Text, pubname.Text, date.Text, code, road, bookIntro.Text, Convert.ToInt32(page.Text), Convert.ToInt32(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.Hide();
            UImain main = new UImain();
            main.Focus();
        }

        #endregion

        #region 更换封面

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UIlocalupload localupload1 = new UIlocalupload();
            if (localupload1.ShowDialog() == DialogResult.OK)
            {
                this.bookimg.BackgroundImage = localupload1.CurrentImage;
            }
        }

        #endregion

        #region 窗口关闭

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
            UImain UImain = new UImain();
            UImain.Focus();
        }

        private void closingform(object sender, FormClosingEventArgs e) //关闭窗体时提示
        {
            if (MessageBox.Show("确定不更新吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void UIbookchange_FormClosing(object sender, FormClosingEventArgs e)
        {
            closingform(sender,e);
        }
        #endregion

        #region 用户列表刷新

        public void bookcommentshow()
        {
            SqlDataReader userinfo;
            try
            {
                userinfo = LibraryBLL.book.bookcommentdata(bookname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = userinfo;
            commentList.DataSource = bs;
        }

        #endregion

        #region 删除评论

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int a = 0; ArrayList name = new ArrayList(); ArrayList commentText = new ArrayList();
            for (int i = 0; i < commentList.RowCount; i++)
            {
                string b, c;
                DataGridViewCell checkbox = (DataGridViewCell)this.commentList.Rows[i].Cells[0];
                if ((string)checkbox.Value == "True")
                {
                    b = commentList.Rows[i].Cells[1].Value.ToString();
                    c = commentList.Rows[i].Cells[4].Value.ToString();
                    name.Add(b);
                    commentText.Add(c);
                }
            }
            if (MessageBox.Show("确定删除" + name.Count + "条数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                LibraryBLL.book comment = new LibraryBLL.book();
                try
                {
                    a = comment.commentdelete(name, commentText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                bookcommentshow();
                MessageBox.Show("已经删除" + a + "条数据"); ;
            }
        }

        #endregion

        #region 其他

        private void page_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groundchange()//背景色设置
        {
            bookinfo.BackColor = Color.FromArgb(50, Color.White);
            bookreview.BackColor = Color.FromArgb(50, Color.White);
        }
        #endregion
  
    }
}
