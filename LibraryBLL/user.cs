using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LibraryBLL
{
    public class user
    {
        #region 登陆
        public static SqlDataReader land(string name, string password)
        {
            SqlDataReader userdate = LibraryDAL.userop.UserLogin(name,password);
            if (userdate.HasRows)
            {
                return userdate;
            }
            else
            {
                throw new Exception("用户名或密码错误，请重新输入");
            }
        }
        #endregion

        #region 注册
        int line;
        public void userlogincheck(string name, string stuname, string stuid, string subject, string qq, string phone, byte[] headima, string password)
        {
            if (name == null || stuname == null || stuid == null || subject == null || phone == null || qq == null || phone == null || password == null)
            {
                throw new Exception("关键字段为空");
            }
            LibraryDAL.userop load = new LibraryDAL.userop();
            try
            {
                line = load.Upload(name, stuname, stuid, subject, qq, phone, headima, password);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("注册失败");
            }
        }
        #endregion

        #region 用户注册检查
        public static void check(string name)
        {
            SqlDataReader userdate = LibraryDAL.userop.namecheck(name);
            if (userdate.HasRows)
            {
                throw new Exception("该用户名已被注册");
            }
        }
        #endregion

        #region 在线检测
        public void online(string time,string name)
        {
            LibraryDAL.userop load = new LibraryDAL.userop();
            try
            {
                line = load.online(time,name);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("在线更新失败");
            }
        }
        #endregion

        #region 登出
        public void offline(string name)
        {
            LibraryDAL.userop load = new LibraryDAL.userop();
            try
            {
                line = load.offline(name);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("离线更新失败");
            }
        }
        #endregion

        #region 头像显示
        public byte[] image(string name)
        {
            SqlDataReader userdate = LibraryDAL.userop.namecheck(name);
            if (userdate.HasRows)
            {
                byte[]b = (byte[])userdate["headima"];
                return b;
            }
            else
            {
                throw new Exception();
            }
        }
        #endregion

        #region 用户数据刷新
        public static SqlDataReader userinfodata()
        {
            SqlDataReader userdate = LibraryDAL.userop.Userinfoout();
            if (userdate.HasRows)
            {
                return userdate;
            }
            else
            {
                throw new Exception("数据库异常，请重新刷新");
            }
        }
        #endregion

        #region 权限变更
        public void levelchange(string name,string level)
        {
            int line,l;
            if(level=="True")
            {
                l = 0;
            }
            else
            {
                l = 1;
            }
            LibraryDAL.userop load = new LibraryDAL.userop();
            try
            {
                line = load.levelupdata(name, l);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("权限更新失败");
            }
        }
        #endregion

        #region 用户删除
        public int userdelete(ArrayList name)
        {
            int line=0;
            foreach(string a in name)
            {
                LibraryDAL.userop load = new LibraryDAL.userop();
                try
                {
                    line += load.Userdelete(a);
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

        #region 头像变更
        public void headchange(string name, byte[] headima)
        {

            LibraryDAL.userop head = new LibraryDAL.userop();
            try
            {
                line = head.headupdata(name, headima);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("头像更新失败");
            }
        }
        #endregion

        #region 用户数据
        public static SqlDataReader lander(string stuname)
        {
            SqlDataReader userdate = LibraryDAL.userop.landerinfo(stuname);
            if (userdate.HasRows)
            {
                return userdate;
            }
            else
            {
                throw new Exception("数据库异常，请重新刷新");
            }
        }
        #endregion

        #region 用户信息变更

        public void userInfochange(string name, string phone,string qq,string sign,string stu_name)
        {
            LibraryDAL.userop load = new LibraryDAL.userop();
            try
            {
                line = load.userInofUpdata(name, phone, qq, sign, stu_name);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (line <= 0)
            {
                throw new Exception("权限更新失败");
            }
        }

        #endregion

        #region 回答提醒
        public static SqlDataReader answerremind(string time)
        {
            try
            {
                SqlDataReader answerremind = LibraryDAL.userop.answerremind(time);
                return answerremind;
            }
            catch (Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }

        }
        #endregion
    }
}
