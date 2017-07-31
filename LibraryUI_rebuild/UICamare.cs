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
    public partial class UICamare : CCSkinMain
    {
        public UICamare()
        {
            InitializeComponent();
            try
            {
                this.headImagePanel1.Start(0, new Size(240,240), 150);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private Image currentImage = null;
        public Image CurrentImage
        {
            get { return currentImage; }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.currentImage = this.headImagePanel1.GetHeadImage();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Camare_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.headImagePanel1.Stop();
        }

    }
}
