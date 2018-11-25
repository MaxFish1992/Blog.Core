using Blog.Core.Common.Helper;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Common.Redis
{
    /// <summary>
    /// 功能描述    ：RedisCacheManager  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/25 12:01:58 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/25 12:01:58 
    /// </summary>
    public class RedisCacheManager : IRedisCacheManager
    {
        private readonly string _redisConnectionString;
        public volatile ConnectionMultiplexer _redisConnection;
        private readonly object _redisConnectionLock = new object();

        public RedisCacheManager()
        {
            string redisConfiguration = Appsettings.App(new string[] { "AppSettings", "RedisCaching", "ConnectionString" });//获取连接字符串
            if (string.IsNullOrWhiteSpace(redisConfiguration))
            {
                throw new ArgumentException("redis config is empty", nameof(redisConfiguration));
            }
            this._redisConnectionString = redisConfiguration;
            this._redisConnection = this.GetRedisConnection();
        }
        public void Clear()
        {
            foreach (var endPoint in this.GetRedisConnection().GetEndPoints())
            {
                var server = this.GetRedisConnection().GetServer(endPoint);
                foreach (var key in server.Keys())
                {
                    this._redisConnection.GetDatabase().KeyDelete(key);
                }
            }
        }

        public TEntity Get<TEntity>(string key)
        {
            var value = this._redisConnection.GetDatabase().StringGet(key);
            if (value.HasValue)
            {
                //需要用的反序列化，将Redis存储的Byte[]，进行反序列化
                return SerializeHelper.Deserialize<TEntity>(value);
            }
            else
            {
                return default(TEntity);
            }
        }

        public void Remove(string key)
        {
            this._redisConnection.GetDatabase().KeyDelete(key);
        }

        public void Set(string key, object value, TimeSpan cacheTime)
        {
            if (value != null)
            {
                //序列化，将object值生成RedisValue
                this._redisConnection.GetDatabase().StringSet(key, SerializeHelper.Serialize(value), cacheTime);
            }
        }
        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Get(string key)
        {
            if (this._redisConnection != null)
            {
                return this._redisConnection.GetDatabase().KeyExists(key);
            }
            return false;
        }
        #region private
        /// <summary>
        /// 核心代码，获取连接实例
        /// 通过双if 夹lock的方式，实现单例模式
        /// </summary>
        /// <returns></returns>
        private ConnectionMultiplexer GetRedisConnection()
        {
            //如果已经连接实例，直接返回
            if (this._redisConnection != null && this._redisConnection.IsConnected)
            {
                return this._redisConnection;
            }
            lock (_redisConnectionLock)
            {
                if (this._redisConnection != null)
                {
                    //释放redis连接
                    this._redisConnection.Dispose();
                }
                this._redisConnection = ConnectionMultiplexer.Connect(this._redisConnectionString);
            }
            return _redisConnection;
        }
        #endregion
    }
}
