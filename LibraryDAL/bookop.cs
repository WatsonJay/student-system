using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryDAL
{
    public class bookop
    {
        #region 书本数据
        public static SqlDataReader bookinfoout()
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select name,type,autor,pubname,date,price,code,pagecode,about from tb_book ", conn);
            SqlDataReader bookinfo = cmd.ExecuteReader();
            //bookinfo.Read();
            return bookinfo;
        }
        #endregion

        #region 书本查找
        public static SqlDataReader bookinfosearchout(string code, string value)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select name,type,autor,pubname,date,price,code,pagecode,about from tb_book where " + code + " like N'%" + value + "%'", conn);
            SqlDataReader bookinfo = cmd.ExecuteReader();
            //bookinfo.Read();
            return bookinfo;
        }
        #endregion

        #region 书本删除
        public int Bookdelete(string name)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("delete from tb_Book where code= '" + name + "'", conn);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 书本数据显示
        public static SqlDataReader bookinfoout(string code)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select name,type,autor,pubname,date,price,code,picture,about,pagecode from tb_book where code='"+code+"' ", conn);
            SqlDataReader bookinfo = cmd.ExecuteReader();
            bookinfo.Read();
            return bookinfo;
        }
        #endregion

        #region 书籍信息变更
        public int bookInofUpdata(string name, string autor, string type, string pubname, string date, string code,byte[] picture,string about,int page,int price)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("update tb_book set name='" + name + "',type='" + type + "',autor='" + autor + "',pubname='" + pubname + "',date='" + date + "',picture=@picturefile,about='" + about + "',pagecode='" + page + "',price='" + price + "' where code='" + code + "' ", conn);
                SqlParameter par = new SqlParameter("@picturefile", SqlDbType.Image);
                par.Value = picture;
                cmd.Parameters.Add(par);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 封面显示
        public static SqlDataReader covershow(string name)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_book where name ='" + name + "'", conn);
            SqlDataReader bookinfo = cmd.ExecuteReader();
            bookinfo.Read();
            return bookinfo;
        }
        #endregion

        #region 书本信息数据上传
        public int Upload(string name, string autor, string type, string pubname, string date, string code, byte[] picture, string about, int page, int price)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                cmd.CommandText = "Insert into tb_book(name,autor,type,pubname,date,code,picture,about,pagecode,price)values('" + name + "','" + autor + "','" + type + "','" + pubname + "','" + date + "','" + code + "',@imgfile,'" + about + "','" + page + "','" + price + "')";
                SqlParameter par = new SqlParameter("@imgfile", SqlDbType.Image);
                par.Value = picture;
                cmd.Parameters.Add(par);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 书评数据显示
        public static SqlDataReader bookcommentout(string name)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select bookname,commenter,date,comment from tb_bookcomment where bookname='" + name + "' ", conn);
            SqlDataReader bookinfo = cmd.ExecuteReader();
            //bookinfo.Read();
            return bookinfo;
        }
        #endregion

        #region 书本评论数据上传
        public int commentUpload(string bookname, string commenter, string date, string comment)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                cmd.CommandText = "Insert into tb_bookcomment(bookname,commenter,date,comment)values('" + bookname + "','" + commenter + "','" + date + "','" + comment + "')";
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 评论删除
        public int Bookcommentdelete(string name,string comment)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("delete from tb_Bookcomment where bookname= '" + name + "'and comment = '"+comment+"'", conn);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion


    }
}
