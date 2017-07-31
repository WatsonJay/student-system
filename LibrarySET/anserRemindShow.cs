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
    public partial class anserRemindShow : UserControl
    {
        public anserRemindShow()
        {
            InitializeComponent();
        }

        public anserRemindShow(object e)
        {
            anser_Remind answerContent = new anser_Remind();
            answerContent = (anser_Remind)e;
            InitializeComponent();
            name.Text = answerContent.answername;
            title.Text = answerContent.questionname;
            time.Text = answerContent.answerdate;
            this.Name = answerContent.questionname;
        }

        private void skinLabel5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
