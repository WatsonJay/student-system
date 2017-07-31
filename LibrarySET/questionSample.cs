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
    public partial class questionSample : UserControl
    {
        public questionSample()
        {
            InitializeComponent();
        }

        public questionSample(object e)
        {
            ask_Content askContent = new ask_Content();
            askContent = (ask_Content)e;
            InitializeComponent();
            Img.BackgroundImage = askContent.contentImg;
            questioner.Text = askContent.name;
            type.Text = "#"+askContent.type.Trim()+"#";
            date.Text = askContent.date;
            title.Text = askContent.title;
            this.Name = askContent.title;
        }
    }
}
