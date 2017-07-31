using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryModel;

namespace LibrarySET
{
    public partial class bookcomment : UserControl
    {
        public bookcomment()
        {
            InitializeComponent();
        }

        public bookcomment(object e)
        {
            book_Comment bookComment = new book_Comment();
            bookComment = (book_Comment)e;
            InitializeComponent();
            Img.BackgroundImage = bookComment.commenterImg;
            user.Text = bookComment.name;
            comment.Text = bookComment.comment;
            floor.Text = bookComment.floor;
            date.Text = bookComment.date;
        }
    }
}
