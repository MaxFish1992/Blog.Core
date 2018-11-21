using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core
{
    /// <summary>
    /// 功能描述    ：UtilConvert  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/21 18:02:10 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/21 18:02:10 
    /// </summary>
    public static class UtilConvert
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static int ObjToInt(this object thisValue)
        {
            int reval = 0;
            if (thisValue == null) return 0;
            if (thisValue != null && thisValue != DBNull.Value && int.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return reval;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static string ObjToString(this object thisValue)
        {
            if (thisValue != null) return thisValue.ToString().Trim();
            return "";
        }
    }
}
