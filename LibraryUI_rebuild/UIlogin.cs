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
    public partial class UIlogin : CCSkinMain
    {
        #region 初始化

            public UIlogin()
            {
                InitializeComponent();
            }

            private string Pwd;
            private string rePwd;
            private bool setphoto=false;

        #endregion

        #region 上传头像

            private void label1_Click(object sender, EventArgs e)//照相上传
            {
                 UICamare camareupload1 = new UICamare();
                if(camareupload1.ShowDialog()==DialogResult.OK)
                {
                    this.head.BackgroundImage = camareupload1.CurrentImage;
                    setphoto = true;
                }
            }

            private void label2_Click(object sender, EventArgs e)//照片上传
            {
                UIlocalupload localupload1 = new UIlocalupload();
                if (localupload1.ShowDialog() == DialogResult.OK)
                {
                    this.head.BackgroundImage = localupload1.CurrentImage;
                    setphoto = true;
                }
            }
        #endregion

        #region 窗体关闭

            private void UIlogin_FormClosing(object sender, FormClosingEventArgs e)//关闭提示
            {
                closingform(sender, e);
            }

            private void closingform(object sender, FormClosingEventArgs e) //关闭窗体时提示
            {
                if (MessageBox.Show("确定不完成注册吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }

            private void cancle_Click(object sender, EventArgs e)
            {
                this.Close();
                UIlanding UIlanding = new UIlanding();
                UIlanding.Focus();
            }

        #endregion

        #region 密码查错

            private void password_Leave(object sender, EventArgs e)
            {
                Pwd = password.Text;
            }

            private void repassword_Leave(object sender, EventArgs e)//密码确认
            {
                rePwd = repassword.Text;
                if (rePwd != Pwd)
                {
                    passwordcheck.Text = "两次密码输入不同，请重新输入";
                }
                else
                {
                    passwordcheck.Text = "";
                }
            }

        #endregion

        #region 注册提交
            private void sure_Click(object sender, EventArgs e)
            {
                if(Pwd!=rePwd)
                {
                    if (MessageBox.Show("两次密码不同，请重新输入") == DialogResult.OK)
                    {
                        this.password.Focus();
                        return;
                    }
                }
                if (!setphoto)
                {
                    if (MessageBox.Show("未设置头像") == DialogResult.OK)
                    {
                        return;
                    }
                }
                try
                {
                    LibraryBLL.user.check(userid.Text);
                }
                catch 
                {
                    if (MessageBox.Show("名字已被注册，请重新输入") == DialogResult.OK)
                    {
                        return;
                    }
                }
                byte[] road = ESBasic.Helpers.ImageHelper.Convert(this.head.BackgroundImage);
                LibraryBLL.user userlogin = new LibraryBLL.user();
                try
                {
                    userlogin.userlogincheck(userid.Text, stuname.Text, stuid.Text, courage.Text, qq.Text, phone.Text, road, password.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (MessageBox.Show("注册成功") == DialogResult.OK)
                {
                    UIlanding uilanding = new UIlanding();
                    this.Hide();
                    uilanding.Focus();
                }
            }
        #endregion

    }
}
