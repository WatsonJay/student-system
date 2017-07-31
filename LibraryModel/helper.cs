using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryModel
{
    /// <summary>
    /// 定义发布消息的委托
    /// </summary>
    /// <param name="sender">发布者</param>
    /// <param name="msg">消息</param>
    public delegate void SendHandler(object sender, object msg);

    public class Helper
    {
        /// <summary>
        ///消息发布的事件
        /// </summary>
        public static event SendHandler eventSend;

        public static void SendMessage(object sender, object msg)
        {
            if (eventSend != null)
            {
                eventSend(sender, msg);
            }
        }
    }

}
