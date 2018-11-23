using Blog.Core.IRepository;
using Blog.Core.Model.Models;
using Blog.Core.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Repository
{
    /// <summary>
    /// 功能描述    ：BlogArticleRepository  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/23 16:19:03 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/23 16:19:03 
    /// </summary>
    public class BlogArticleRepository : BaseRepository<BlogArticle>, IBlogArticleRepository
    {
        
    }
}
