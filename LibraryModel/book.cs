
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LibraryModel
{
    public class book_Param
    {
        public string name { get; set; }
        public string type { get; set; }
        public string autor { get; set; }
        public string pubname { get; set; }
        public string date { get; set; }
        public Image BookImg { get; set; }
        public string about { get; set; }
        public string page{ get; set; }
        public string code { get; set; }

    }
    public class book_Comment
    {
        public string name { get; set; }
        public string comment { get; set; }
        public Image commenterImg { get; set; }
        public string floor { get; set; }
        public string date { get; set; }
    }
}
