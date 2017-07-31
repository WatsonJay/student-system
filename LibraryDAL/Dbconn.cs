using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LibraryDAL
{
    class Dbconn
    {
        public static SqlConnection LibCon()
        {
            return new SqlConnection("server=DESKTOP-0BOL1LO;database=db_libary;user id=sa;password=19941121");
        }
    }
}
