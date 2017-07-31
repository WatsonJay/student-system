using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using LibraryModel;

namespace LibraryUI_rebuild
{
    public partial class UIheadchange : CCSkinMain
    {
        #region 变量

        private bool setphoto = false;
        private string name;//姓名
        private Image headimg; //头像
        private user_Param userParam; //用户数据缓存
        bool k = false;
        #endregion

        #region 初始化

        public UIheadchange()
        {
            InitializeComponent();
        }

        #endregion

        #region 带参构造

        public UIheadchange(user_Param userParam):this()
        {
            this.name = userParam.name;
            this.head.BackgroundImage = userParam.HeadImg;
        }

        #endregion

        #region 更改头像

        private void localload_Click(object sender, EventArgs e) //本地上传
        {
            UIlocalupload localupload1 = new UIlocalupload();
            if (localupload1.ShowDialog() == DialogResult.OK)
            {
                this.headchanged.BackgroundImage = localupload1.CurrentImage;
                setphoto = true;
            }
        }

        private void cameraload_Click(object sender, EventArgs e) //相机上传
        {
            UICamare camareupload1 = new UICamare();
            if (camareupload1.ShowDialog() == DialogResult.OK)
            {
                this.headchanged.BackgroundImage = camareupload1.CurrentImage;
                setphoto = true;
            }
        }

        #endregion

        #region 其他

            #region 拍照上传文本变色

        private void cameraload_MouseEnter(object sender, EventArgs e)
            {
                cameraload.ForeColor = Color.Blue;
            }

            private void cameraload_MouseLeave(object sender, EventArgs e)
            {
                cameraload.ForeColor = Color.Black;
            }

            private void cameraload_MouseHover(object sender, EventArgs e)
            {
                cameraload.ForeColor = Color.Gray;
            }

            #endregion

            #region 本地上传文本变色

            private void localload_MouseEnter(object sender, EventArgs e)
            {
                localload.ForeColor = Color.Blue;
            }

            private void localload_MouseLeave(object sender, EventArgs e)
            {
                localload.ForeColor = Color.Black;
            }

            private void localload_MouseHover(object sender, EventArgs e)
            {
                localload.ForeColor = Color.Gray;
            }

            #endregion

            private void timer1_Tick(object sender, EventArgs e)
            {
                if (!setphoto)
                {
                    sure.Enabled = false;
                }
                else
                {
                    sure.Enabled = true;
                }
            }

        #endregion

        #region 窗体关闭

            private void closingform(object sender, FormClosingEventArgs e) //关闭窗体时提示
            {
                if (!k)
                {
                    if (MessageBox.Show("确定不更新头像吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }

            private void cancle_Click(object sender, EventArgs e)
            {
                this.Close();
                UImain UImain = new UImain();
                UImain.Focus();
            }

            private void headchange_FormClosing(object sender, FormClosingEventArgs e)
            {
                closingform(sender,e);
            }

        #endregion

        #region 头像更新

            private void sure_Click(object sender, EventArgs e)
            {
                byte[] road = ESBasic.Helpers.ImageHelper.Convert(this.headchanged.BackgroundImage);
                LibraryBLL.user change = new LibraryBLL.user();
                try
                {
                    change.headchange(name, road);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                k = true;
                UImain main = new UImain();
                this.Hide();
                main.Focus();
            }

        #endregion
    }
}
