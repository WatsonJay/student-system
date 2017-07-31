using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryUI
{
    public partial class UIlogin : Form
    {
        private string Pwd;
        private string rePwd;
        private bool setphoto=false;
        public UIlogin()
        {
            InitializeComponent();
        }

        private void repassword_TextChanged(object sender, EventArgs e) ////输入密码时密码赋值给变量并与Password比较
        {
            rePwd = repassword.Text;
            if(rePwd!=Pwd)
            {
                passwordcheck.Text = "两次密码输入不同，请重新输入";
            }
            else
            {
                passwordcheck.Text = "";
            }
        }

        private void password_TextChanged(object sender, EventArgs e) //输入密码时密码赋值给变量
        {
            Pwd = password.Text;
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
            UIlanding UIlanding = new UIlanding();
            UIlanding.Focus();
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

        private void UIlogin_closeing(object sender, FormClosingEventArgs e) //关闭窗体
        {
            closingform(sender, e);
        }

        private void cameraupload_MouseEnter(object sender, EventArgs e)
        {
            cameraupload.ForeColor = Color.Blue;
        }

        private void cameraupload_MouseLeave(object sender, EventArgs e)
        {
            cameraupload.ForeColor = Color.Black;
        }

        private void localupload_MouseEnter(object sender, EventArgs e)
        {
            localupload.ForeColor = Color.Blue;
        }

        private void localupload_MouseLeave(object sender, EventArgs e)
        {
            localupload.ForeColor = Color.Black;
        }

        private void localupload_Click(object sender, EventArgs e)
        {
            Localupload localupload1 = new Localupload();
            if(localupload1.ShowDialog()==DialogResult.OK)
            {
                this.head.BackgroundImage = localupload1.CurrentImage;
                setphoto = true;
            }
        }

        private void cameraupload_Click(object sender, EventArgs e)
        {
            Camare camareupload1 = new Camare();
            if(camareupload1.ShowDialog()==DialogResult.OK)
            {
                this.head.BackgroundImage = camareupload1.CurrentImage;
                setphoto = true;
            }
        }

        private void login_Click(object sender, EventArgs e)
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
                LibraryBLL.namecheck.check(name.Text);
            }
            catch 
            {
                if (MessageBox.Show("名字已被注册，请重新输入") == DialogResult.OK)
                {
                    return;
                }
            }
            byte[] road = ESBasic.Helpers.ImageHelper.Convert(this.head.BackgroundImage);
            LibraryBLL.Userlogin userlogin = new LibraryBLL.Userlogin();
            try
            {
                userlogin.userlogincheck(name.Text, stuname.Text, stuid.Text, courage.Text, qq.Text, phone.Text, road, password.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if(MessageBox.Show("注册成功")==DialogResult.OK)
            {
                UIlanding uilanding = new UIlanding();
                uilanding.Focus();
                this.Hide();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LibraryBLL.namecheck.check(name.Text);
            }
            catch
            {
                usercheck.Text = "该用户名已被注册";
                return;
            }
            usercheck.Text = "";
        }

        private void stuid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = LibraryBLL.keycheck.check(e.KeyChar);
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = LibraryBLL.keycheck.check(e.KeyChar);
        }

        private void qq_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = LibraryBLL.keycheck.check(e.KeyChar);
        }

        private void UIlogin_Load(object sender, EventArgs e)
        {
            //courage.Text=courage.Items[]
        }
    }
}
