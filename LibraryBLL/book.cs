using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryBLL
{
    public class book
    {
        #region 书本数据
        public static SqlDataReader bookinfodata()
        {
            try
            {
                SqlDataReader bookdate = LibraryDAL.bookop.bookinfoout();
                return bookdate;
            }
            catch(Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }
              
        }
        #endregion

        #region 书本数据查询
        public static SqlDataReader bookinfosearchdata(string code,string value)
        {
            LibraryBLL.cntoeng l = new LibraryBLL.cntoeng();
            string codeen = l.booksearchuse(code);
            SqlDataReader bookdate = LibraryDAL.bookop.bookinfosearchout(codeen, value);
            if (bookdate.HasRows)
            {
                return bookdate;
            }
            else
            {
                throw new Exception("数据库暂无书目或查询异常，请更新关键字");
            }
        }
        #endregion

        #region 类型判定

        public static SqlDataReader bookshowswitch(string code, string value)
        {
            try
            {
                SqlDataReader bookdate; 
                if (code == "" || value == "")
                {
                     bookdate = bookinfodata();
                }
                else
                {
                     bookdate = bookinfosearchdata(code, value);
                }
                return bookdate; 
            }
            catch(Exception e){
                throw e;
            }
        }

        #endregion

        #region 书本删除
        public int bookdelete(ArrayList name)
        {
            int line = 0;
            foreach (string a in name)
            {
                LibraryDAL.bookop load = new LibraryDAL.bookop();
                try
                {
                    line += load.Bookdelete(a);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            if (line <= 0)
            {
                throw new Exception("删除失败");
            }
            return line;
        }
        #endregion

        #region 书本数据显示
        public static SqlDataReader bookinfodata(string code)
        {
            try
            {
                SqlDataReader bookdate = LibraryDAL.bookop.bookinfoout(code);
                return bookdate;
            }
            catch (Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }

        }
        #endregion

        #region 书本信息变更

        int line;

        public void bookinfochange(string name, string autor, string type, string pubname, string date, string code,byte[] picture,string about,int page,int price)
        {
            LibraryDAL.bookop load = new LibraryDAL.bookop();
            try
            {
                line = load.bookInofUpdata(name,autor,type,pubname,date,code,picture,about,page,price);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("信息变更失败");
            }
        }
        #endregion

        #region 头像显示
        public byte[] covershow(string name)
        {
            SqlDataReader coverdate = LibraryDAL.bookop.covershow(name);
            if (coverdate.HasRows)
            {
                byte[] b = (byte[])coverdate["picture"];
                return b;
            }
            else
            {
                throw new Exception();
            }
        }
        #endregion

        #region 增加图书

        public void bookCheckIn(string name, string autor, string type, string pubname, string date, string code, byte[] picture, string about, int page, int price)
        {
            if (name == null || autor == null || type == null || pubname == null || date == null || code == null || about == null || page == null || price == null)
            {
                throw new Exception("关键字段为空");
            }
            LibraryDAL.bookop load = new LibraryDAL.bookop();
            try
            {
                line = load.Upload(name,autor,type,pubname,date,code,picture,about,page,price);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("书本增加失败");
            }
        }
        #endregion

        #region 书评数据显示
        public static SqlDataReader bookcommentdata(string name)
        {
            try
            {
                SqlDataReader bookcomment = LibraryDAL.bookop.bookcommentout(name);
                return bookcomment;
            }
            catch (Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }

        }
        #endregion

        #region 发布评论

        public void bookCommentCheckIn(string bookname, string commenter, string date, string comment)
        {
            if (bookname == null || commenter == null || date == null || comment == null )
            {
                throw new Exception("关键字段为空");
            }
            LibraryDAL.bookop load = new LibraryDAL.bookop();
            try
            {
                line = load.commentUpload(bookname,commenter,date,comment);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("评论发布失败");
            }
        }

        #endregion

        #region 评论删除
        public int commentdelete(ArrayList name,ArrayList comment)
        {
            int line = 0;
            for (int i = 0; i < name.Count;i++)
            {
                string a = name[i].ToString();
                string b = comment[i].ToString();
                LibraryDAL.bookop load = new LibraryDAL.bookop();
                try
                {
                    line += load.Bookcommentdelete(a,b);
                }
                catch (Exception e)
                {
                    throw e;
                }
                if (line <= 0)
                {
                    throw new Exception("删除失败");
                }
            }
            return line;
        }
        #endregion

    }
}
