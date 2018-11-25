using Blog.Core.IServices.Base;
using Blog.Core.Model.Models;
using Blog.Core.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.IServices
{
    /// <summary>
    /// 功能描述    ：IBlogArticleServices  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/23 16:13:21 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/23 16:13:21 
    /// </summary>
    public interface IBlogArticleServices:IBaseServices<BlogArticle>
    {
        /// <summary>
        /// 获取博客列表
        /// </summary>
        /// <param name="id">博客id</param>
        /// <returns></returns>
        Task<List<BlogArticle>> GetBlogs();
        Task<BlogViewModels> getBlogDetails(int id);
    }
}
