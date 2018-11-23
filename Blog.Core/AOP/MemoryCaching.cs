using Microsoft.Extensions.Caching.Memory;
using System;

namespace Blog.Core.AOP
{
    public class MemoryCaching : ICaching
    {
        private IMemoryCache _memoryCache;
        public MemoryCaching(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public object Get(string cacheKey)
        {
            return _memoryCache.Get(cacheKey);
        }

        public void Set(string cacheKey, object cacheValue)
        {
            _memoryCache.Set(cacheKey, cacheValue,TimeSpan.FromSeconds(7200));//添加缓存并设置过期时间
        }
    }
}
