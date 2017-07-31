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
    public partial class Localupload : Form
    {
        public Localupload()
        {
            InitializeComponent();
            try
            {
                this.imagePartSelecter1.ImagePartSelected += new ESBasic.CbGeneric<Bitmap>(imagePartSelecter1_ImagePartSelected);
                this.imagePartSelecter1.Initialize(150);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        void imagePartSelecter1_ImagePartSelected(Bitmap obj) //截取图片
        {
            this.currentImage = obj;
        }


        private Image currentImage = null;
        public Image CurrentImage
        {
            get { return currentImage; }
        } 

        private void button1_Click(object sender, EventArgs e) //上传图片
        {
            string file = ESBasic.Helpers.FileHelper.GetFileToOpen("请选择想要的图片");
            if (file == null)
            {
                return;
            }
            Image image = Image.FromFile(file);
            this.imagePartSelecter1.SetSourceImage(image);
            this.DialogResult = System.Windows.Forms.DialogResult.None;
        }

        private void sure_Click(object sender, EventArgs e)
        {
            if (this.currentImage == null)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
