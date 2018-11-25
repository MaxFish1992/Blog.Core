using Blog.Core.Common.Helper;

namespace Blog.Core.Repository.sugar
{
    /// <summary>
    /// 功能描述    ：BaseDBConfig  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/22 15:21:39 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/22 15:21:39 
    /// </summary>
    public class BaseDBConfig
    {
        public static string ConnectionString { get; set; } = Appsettings.App(new string[] { "Appsettings", "SqlServer", "SqlServerConnection" });

        //正常格式是

        //public static string ConnectionString = "server=.;uid=sa;pwd=sa;database=BlogDB"; 

        //原谅我用配置文件的形式，因为我直接调用的是我的服务器账号和密码，安全起见

    }
}
