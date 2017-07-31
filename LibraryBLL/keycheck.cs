using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL
{
     public class keycheck
    {
        public static bool check(char keychar)
        {
            if(!(Char.IsNumber(keychar))&&keychar!=(char)8)
            {
                return true;
            }
            else
            {
                return false;
            }
         }
    }
}
