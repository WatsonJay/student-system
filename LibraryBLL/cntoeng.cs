using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryBLL
{
    public class cntoeng
    {
        #region 管理员页面刷新

        public string booksearchuse(string cn)//字段转换
        {
            switch(cn)
            {
                case "书名":return "name";
                case "类型": return "type";
                case "作者": return "autor";
                case "出版社": return "pubname";
                case "年份": return "date";
                default: return "";

            }
        }

        #endregion
    }
}
