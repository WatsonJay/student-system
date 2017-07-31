using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace LibraryDAL
{
    public class userop
    {
        #region 登陆数据检测
        public static SqlDataReader UserLogin(string name,string password) 
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_User where name='" + name + "' and password='" + password + "'", conn);
            SqlDataReader usercheck = cmd.ExecuteReader();
            usercheck.Read();
            return usercheck;
        }
        #endregion

        #region 用户名重复检测
        public static SqlDataReader namecheck(string name)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_User where name='" + name + "'", conn);
            SqlDataReader usercheck = cmd.ExecuteReader();
            usercheck.Read();
            return usercheck;
        }
        #endregion

        #region 在线
        public int online(string time,string name)
        {
            int i = 1;
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("update tb_User set onlinedate='" + time + "',online='" + i + "' where name='" + name + "' ", conn);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 离线
        public int offline(string name)
        {
            int i = 0;
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("update tb_User set online='" + i + "' where student_name='" + name + "'", conn);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 用户注册数据上传
        public int Upload(string name, string stuname, string stuid, string subject, string qq, string phone, byte[] headpath, string password)
        {
            SqlConnection conn =LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=conn;
            try
            {
                cmd.CommandText = "Insert into tb_User(name,student_name,student_id,subject,password,qq,phone,headima,level,borrownum,online)values('" + name + "','" + stuname + "','" + stuid + "','" + subject + "','" + password + "','" + qq + "','" + phone + "',@imgfile,0,0,0)";
                SqlParameter par = new SqlParameter("@imgfile", SqlDbType.Image);
                par.Value = headpath;
                cmd.Parameters.Add(par);
            }
           catch(Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 用户数据显示刷新
        public static SqlDataReader Userinfoout()
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select name,student_name,student_id,subject,qq,phone,level,borrownum,online from tb_User ", conn);
            SqlDataReader userinfo = cmd.ExecuteReader();
            //userinfo.Read();
            return userinfo;
        }
        #endregion

        #region 管理员权限变更
        public int levelupdata(string name, int level)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
               cmd = new SqlCommand("update tb_User set level='"+level+"'where name='"+name+"' ", conn);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 头像变更
        public int headupdata(string stuname, byte[] headima)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("update tb_User set headima= @imgfile where student_name='" + stuname + "' ", conn);
                SqlParameter par = new SqlParameter("@imgfile", SqlDbType.Image);
                par.Value = headima;
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

        #region 用户删除
        public int Userdelete(string name)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("delete from tb_User where name= '"+name+"'", conn);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 用户数据显示
        public static SqlDataReader landerinfo(string stuname)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select name,student_id,subject,qq,phone,level,borrownum,signature,online from tb_User where student_name='" + stuname + "'", conn);
            SqlDataReader userinfo = cmd.ExecuteReader();
            userinfo.Read();
            return userinfo;
        }
        #endregion

        #region 用户信息变更
        public int userInofUpdata(string name, string phone, string qq, string sign, string stu_name)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("update tb_User set name='" + name + "',phone='" + phone + "',qq='"+qq+"',signature='"+sign+"' where student_name='" + stu_name + "' ", conn);
            }
            catch (Exception e)
            {
                throw e;
            }
            int line = cmd.ExecuteNonQuery();
            return line;
        }
        #endregion

        #region 回答消息提示
        public static SqlDataReader answerremind(string time)
        {
            SqlConnection conn = LibraryDAL.Dbconn.LibCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select answerName,answertime,qusetionId from tb_answer where answertime <'" + time + "'", conn);
            SqlDataReader answerremind = cmd.ExecuteReader();
            return answerremind;
        }
        #endregion

    }
}
