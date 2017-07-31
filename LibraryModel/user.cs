using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryModel
{
    public class user_Param
    {
        public string name { get; set; }
        public string stuname { get; set; }
        public string stuid { get; set; }
        public string phone { get; set; }
        public string qq { get; set; }
        public Image HeadImg { get; set; }
        public bool level { get; set; }
        public string lastonline { get; set; }

    }
         public class anser_Remind
    {
        public string answername { get; set; }
        public string answerdate { get; set; }
        public string questionname { get; set; }
    }
}
