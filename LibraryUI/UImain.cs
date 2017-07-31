using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI
{
    public partial class UImain : Form
    {
        public UImain()
        {
            InitializeComponent();
        }
        public string user;
        public bool level;
        public byte[] bima;
        public bool list;
        private UIuserinform inform = null;

        private void groundchange()
        {
            splitContainer1.Panel1.BackColor = Color.FromArgb(100, Color.White);
            splitContainer1.Panel2.BackColor = Color.FromArgb(100, Color.White);
            settinglist.BackColor = Color.FromArgb(50, Color.Gray);
            label1.BackColor = Color.FromArgb(100, Color.Gray);
            label2.BackColor = Color.FromArgb(100, Color.Gray);
            landedname.BackColor = Color.FromArgb(100, Color.Gray);
            landedlevel.BackColor = Color.FromArgb(100, Color.Gray);
        }

        private void UImain_Load(object sender, EventArgs e)
        {
            groundchange();
            seachtype.Text = seachtype.Items[0].ToString();
            settinglist.Hide(); list = false;
            user = LibraryModel.user.name; level = LibraryModel.user.level; bima = LibraryModel.user.headpath;
            Head.BackgroundImage = LibraryBLL.drawimag.headima(bima,Head.Width,Head.Height);
            if (level)
                landedlevel.Text = "管理员";
            else
                landedlevel.Text = "普用用户";
            landedname.Text = user;
        }
 
        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackgroundImage = Properties.Resources.gray;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackgroundImage = Properties.Resources.white;
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!list)
            {
                settinglist.Show();
                list = true;
            }
            else
            {
                settinglist.Hide();
                list = false;
            }
        }

        private void UImain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void landedname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(inform==null||inform.IsDisposed)
            {
                inform = new UIuserinform();
            }
                inform.Show();
                inform.Focus();
        }
    }
}
