using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryDAL
{
    public class questionop
    {
        #region 问题显示
        public static SqlDataReader askContentout()
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select id,title,type,uploadTime,questionerId from tb_question", conn);
            SqlDataReader askcontent = cmd.ExecuteReader();
            //bookinfo.Read();
            return askcontent;
        }
        #endregion

        #region 问题查询显示
        public static SqlDataReader askContentout(string type)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select id,title,type,uploadTime,questionerId from tb_question where type='" + type + "'", conn);
            SqlDataReader askcontent = cmd.ExecuteReader();
            //bookinfo.Read();
            return askcontent;
        }
        #endregion

        #region 问题详细显示
        public static SqlDataReader connentmainshowdate(string title)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_question where title='" + title + "' ", conn);
            SqlDataReader bookinfo = cmd.ExecuteReader();
            bookinfo.Read();
            return bookinfo;
        }
        #endregion

        #region 问题上传
        public int questionUpload(string title, string type, string about, string filename, string uploadTime, string questionerId)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                cmd.CommandText = "Insert into tb_question(title, type, about, filename, uploadTime, questionerId)values('" + title + "','" + type + "','" + about + "','" + filename + "','" + uploadTime + "','" + questionerId + "')";
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 回答查询显示
        public static SqlDataReader answerContentout(int ID)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select intro,answerName,fileName,answertime from tb_answer where qusetionId='" + ID + "'", conn);
            SqlDataReader askcontent = cmd.ExecuteReader();
            //bookinfo.Read();
            return askcontent;
        }
        #endregion

        #region 问题上传
        public int answerUpload(string intro, int questionId, string answerName, string answertime, string fileName)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                cmd.CommandText = "Insert into tb_answer(intro,qusetionId,answerName,answertime,fileName)values('" + intro + "','" + questionId + "','" + answerName + "','" + answertime + "','" + fileName + "')";
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 问题删除
        public int questioncommentdelete(string name)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("delete from tb_question where title= '" + name + "'", conn);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 问题标题
        public static SqlDataReader questionname(int id)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select title from tb_question where id='" + id + "' ", conn);
            SqlDataReader question = cmd.ExecuteReader();
            question.Read();
            return question;
        }
        #endregion
    }
}
