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
    public partial class Camare : Form
    {
        public Camare()
        {
            InitializeComponent();
            try
            {
                this.headImagePanel1.Start(0, new Size(422, 336), 150);
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

        private void sure_Click(object sender, EventArgs e)
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
