using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Common.Helper
{
    /// <summary>
    /// 功能描述    ：appsettings.json操作类  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/25 11:36:12 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/25 11:36:12 
    /// </summary>
    public class Appsettings
    {
        static IConfiguration Configuration { get; set; }

        static Appsettings()
        {
             Configuration = new ConfigurationBuilder()
             .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })//ReloadOnChange = true 当appsettings.json被修改时重新加载
             .Build();
        }
        /// <summary>
        /// 封装要操作的字符
        /// </summary>
        /// <param name="sections"></param>
        /// <returns></returns>
        public static string App(params string[] sections)
        {
            try
            {
                var val = string.Empty;
                for (int i = 0; i < sections.Length; i++)
                {
                    val += sections[i] + ":";
                }
                return Configuration[val.TrimEnd(':')];
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
