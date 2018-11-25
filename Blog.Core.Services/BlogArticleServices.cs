using Blog.Core.Common.Attribute;
using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    /// <summary>
    /// 功能描述    ：BlogArticleServices  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/23 16:15:36 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/23 16:15:36 
    /// </summary>
    public class BlogArticleServices : BaseServices<BlogArticle>, IBlogArticleServices
    {
        IBlogArticleRepository dal;
        public BlogArticleServices(IBlogArticleRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
        /// <summary>
        /// 获取博客列表
        /// </summary>
        /// <returns></returns>
        [Caching(AbsoluteExpiration =10)]//增加特性
        public async Task<List<BlogArticle>> GetBlogs()
        {
            var bloglist = await dal.Query(a => a.bID > 0, a => a.bID);
            return bloglist;
        }
    }
}
