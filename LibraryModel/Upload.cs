using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
        public class answer_Content
        {
            public string name { get; set; }
            public string content { get; set; }
            public Image contentImg { get; set; }
            public string floor { get; set; }
            public string date { get; set; }

            public string fileName{ get; set; }
        }

        public class ask_Content
        {
            public string name { get; set; }
            public string title { get; set; }
            public Image contentImg { get; set; }
            public string date { get; set; }
            public string type { get; set; }
        }
}
