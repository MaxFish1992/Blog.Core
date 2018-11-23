using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.AOP
{
    /// <summary>
    /// 简单的缓存接口，只有查询和添加，以后会进行扩展
    /// </summary>
    public interface ICaching
    {
        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="cacheKey">key</param>
        /// <returns></returns>
        object Get(string cacheKey);
        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="cacheKey">key</param>
        /// <param name="cacheValue">value</param>
        void Set(string cacheKey, object cacheValue);
    }
}
