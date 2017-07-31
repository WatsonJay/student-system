using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL
{
    public class programoff
    {
        public void cleanalluserinfo()
        {
            LibraryModel.user.name = "";
            LibraryModel.user.level = false;
            LibraryModel.user.stuname = "";
            LibraryModel.user.stuid = "";
            LibraryModel.user.phone = "";
            LibraryModel.user.qq = "";
            LibraryModel.user.headpath = null;
        }
    }
}
