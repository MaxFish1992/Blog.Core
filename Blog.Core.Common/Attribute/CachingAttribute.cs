using System;

namespace Blog.Core.Common.Attribute
{
    /// <summary>
    /// 功能描述    ：这个Attribute就是使用时候的验证，把它添加到要缓存数据的方法中，即可完成缓存的操作。  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/25 11:17:19 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/25 11:17:19 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class CachingAttribute : System.Attribute
    {
        //缓存绝对过期时间
        public int AbsoluteExpiration { get; set; } = 30;
    }
}
