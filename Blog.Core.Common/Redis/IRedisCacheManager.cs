using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Common.Redis
{
    /// <summary>
    /// 功能描述    ：IRedisCacheManager  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/25 12:00:00 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/25 12:00:00 
    /// </summary>
    public interface IRedisCacheManager
    {
        /// <summary>
        /// 获取
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        TEntity Get<TEntity>(string key);
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="cacheTime">过期时间</param>
        void Set(string key, object value, TimeSpan cacheTime);
        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="key"></param>
        void Remove(string key);
        /// <summary>
        /// 清空
        /// </summary>
        void Clear();
    }
}
