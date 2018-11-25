using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Common.Helper
{
    /// <summary>
    /// 功能描述    ：序列化对象操作类  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/25 11:57:06 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/25 11:57:06 
    /// </summary>
    public class SerializeHelper
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static byte[] Serialize(object item)
        {
            var jsonString = JsonConvert.SerializeObject(item);
            return Encoding.UTF8.GetBytes(jsonString);
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TEntity Deserialize<TEntity>(byte[] value)
        {
            if (value == null)
            {
                return default(TEntity);
            }
            var jsonString = Encoding.UTF8.GetString(value);
            return JsonConvert.DeserializeObject<TEntity>(jsonString);
        }
    }
}
