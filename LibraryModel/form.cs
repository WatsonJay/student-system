using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryModel
{
    #region eFrom枚举

    public enum eFrom
    {
        /// <summary>
        /// 显示提示窗口
        /// </summary>
        Show_Tip,
        /// <summary>
        /// 显示主窗口
        /// </summary>
        Show_Main,
        /// <summary>
        /// 修改主窗背景
        /// </summary>
        Main_BackImg,
        /// <summary>
        /// 修改头像
        /// </summary>
        Show_headchange,
        /// <summary>
        /// 修改书本信息
        /// </summary>
        Show_bookchange,
    }

    #endregion
}
