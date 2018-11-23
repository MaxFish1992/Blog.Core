using Blog.Core.IRepository.Base;
using Blog.Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.IRepository
{
    /// <summary>
    /// 功能描述    ：IBlogArticleRepository  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/23 16:17:42 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/23 16:17:42 
    /// </summary>
    public interface IBlogArticleRepository:IBaseRepository<BlogArticle>
    {
        
    }
}
