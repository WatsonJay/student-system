using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryBLL
{
    public class question
    {
        int line;

        #region 问题显示
        public static SqlDataReader askContent()
        {
            try
            {
                SqlDataReader askContentdate = LibraryDAL.questionop.askContentout();
                return askContentdate;
            }
            catch (Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }

        }
        #endregion

        #region 问题查询显示
        public static SqlDataReader askContent(string type)
        {
            try
            {
                SqlDataReader askContentdate = LibraryDAL.questionop.askContentout(type);
                return askContentdate;
            }
            catch (Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }

        }
        #endregion

        #region 回答显示
        public static SqlDataReader answerContent(int ID)
        {
            try
            {
                SqlDataReader askContentdate = LibraryDAL.questionop.answerContentout(ID);
                return askContentdate;
            }
            catch (Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }

        }
        #endregion

        #region 详情展示

        public static SqlDataReader conentmainshow(string title)
        {
            try
            {
                SqlDataReader bookdate = LibraryDAL.questionop.connentmainshowdate(title);
                return bookdate;
            }
            catch (Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }
        }

        #endregion

        #region 发布评论

        public void questionCheckIn(string title, string type, string about, string filename, string uploadTime, string questionerId)
        {
            if (title == null || type == null || about == null || uploadTime == null || questionerId == null)
            {
                throw new Exception("关键字段为空");
            }
            LibraryDAL.questionop load = new LibraryDAL.questionop();
            try
            {
                line = load.questionUpload(title, type, about, filename, uploadTime, questionerId);
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

        #region 发布回答

        public void answerCheckIn(string intro, int questionId, string answerName, string answertime, string fileName)
        {
            if (intro == null || questionId == null || answerName == null || answertime == null || fileName == null)
            {
                throw new Exception("关键字段为空");
            }
            LibraryDAL.questionop load = new LibraryDAL.questionop();
            try
            {
                line = load.answerUpload(intro,questionId,answerName,answertime,fileName);
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

        #region 删除问题
        public int questiondelete(ArrayList name)
        {
            int line = 0;
            for (int i = 0; i < name.Count;i++)
            {
                string a = name[i].ToString();
                LibraryDAL.questionop load = new LibraryDAL.questionop();
                try
                {
                    line += load.questioncommentdelete(a);
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

        #region 问题名称

        public static SqlDataReader questionname(int ID)
        {
            try
            {
                SqlDataReader bookdate = LibraryDAL.questionop.questionname(ID);
                return bookdate;
            }
            catch (Exception e)
            {
                throw new Exception("数据库异常，请重新刷新");
            }
        }

        #endregion

    }
}
