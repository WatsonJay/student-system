using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryUI_rebuild
{
    public partial class UIbookadd : CCSkinMain
    {

        #region 变量

        public UIbookadd()
        {
            InitializeComponent();
            bookname.Focus();
            date.Text = System.DateTime.Now.ToString();
        }

        #endregion

        #region 书本信息变更

        private void sure_Click(object sender, EventArgs e)
        {
            if(bookname.Text==""||autor.Text==""||pubname.Text==""||type.Text==""||date.Text==""||bookIds.Text==""||page.Text==""||textBox1.Text==""||bookIntro.Text=="")
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

            string[] code = this.bookIds.Text.Trim().Split(';');
            for(int i=0;i<code.Length;i++)
            {
                byte[] road = ESBasic.Helpers.ImageHelper.Convert(this.bookimg.BackgroundImage);
                LibraryBLL.book bookupdate = new LibraryBLL.book();
                try
                {
                    bookupdate.bookCheckIn(bookname.Text, autor.Text, type.Text, pubname.Text, date.Text, code[i], road, bookIntro.Text, Convert.ToInt32(page.Text), Convert.ToInt32(textBox1.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            if (MessageBox.Show("书本增加成功") == DialogResult.OK)
            {
                this.Hide();
                UImain main = new UImain();
                main.Focus();
            }
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
            UImain UImain = new UImain();
            UImain.Focus();
        }

        #endregion

        #region 选择封面

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UIlocalupload localupload1 = new UIlocalupload();
            if (localupload1.ShowDialog() == DialogResult.OK)
            {
                this.bookimg.BackgroundImage = localupload1.CurrentImage;
            }
        }

        #endregion

    }
}
