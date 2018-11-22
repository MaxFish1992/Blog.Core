using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Model
{
    /// <summary>
    /// 功能描述    ：通用返回信息类  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/22 9:51:58 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/22 9:51:58 
    /// </summary>
    public class MessageModel<T>
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 返回数据集合
        /// </summary>
        public List<T> Data { get; set; }
    }
}
