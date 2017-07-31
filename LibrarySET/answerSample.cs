using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryModel;

namespace LibrarySET
{
    public partial class answerSample : UserControl
    {
        public answerSample()
        {
            InitializeComponent();
        }
        public answerSample(object e)
        {
            answer_Content answerContent = new answer_Content();
            answerContent = (answer_Content)e;
            InitializeComponent();
            Img.BackgroundImage = answerContent.contentImg;
            user.Text = answerContent.name;
            comment.Text = answerContent.content;
            floor.Text = answerContent.floor;
            date.Text = answerContent.date;
            fileName.Text = answerContent.fileName;
            if(fileName.Text.Trim()!="")
            {
                dowenload.Visible = true;
            }
            else
            {
                dowenload.Visible = false;
            }
        }

        private void dowenload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                b.answerDownload(filePath, fileName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("下载成功");
        }
    }
}
