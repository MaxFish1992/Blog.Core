using Blog.Core.Common.Attribute;
using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Model.ViewModels;
using Blog.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// 获取视图博客详情信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<BlogViewModels> getBlogDetails(int id)
        {
            var bloglist = await dal.Query(a => a.bID > 0, a => a.bID);
            var idmin = bloglist.FirstOrDefault() != null ? bloglist.FirstOrDefault().bID : 0;
            var idmax = bloglist.LastOrDefault() != null ? bloglist.LastOrDefault().bID : 1;
            var idminshow = id;
            var idmaxshow = id;

            BlogArticle blogArticle = new BlogArticle();

            blogArticle = (await dal.Query(a => a.bID == idminshow)).FirstOrDefault();

            BlogArticle prevblog = new BlogArticle();


            while (idminshow > idmin)
            {
                idminshow--;
                prevblog = (await dal.Query(a => a.bID == idminshow)).FirstOrDefault();
                if (prevblog != null)
                {
                    break;
                }
            }

            BlogArticle nextblog = new BlogArticle();
            while (idmaxshow < idmax)
            {
                idmaxshow++;
                nextblog = (await dal.Query(a => a.bID == idmaxshow)).FirstOrDefault();
                if (nextblog != null)
                {
                    break;
                }
            }


            blogArticle.btraffic += 1;
            await dal.Update(blogArticle, new List<string> { "btraffic" });

            BlogViewModels models = new BlogViewModels()
            {
                bsubmitter = blogArticle.bsubmitter,
                btitle = blogArticle.btitle,
                bcategory = blogArticle.bcategory,
                bcontent = blogArticle.bcontent,
                btraffic = blogArticle.btraffic,
                bcommentNum = blogArticle.bcommentNum,
                bUpdateTime = blogArticle.bUpdateTime,
                bCreateTime = blogArticle.bCreateTime,
                bRemark = blogArticle.bRemark,
            };

            if (nextblog != null)
            {
                models.next = nextblog.btitle;
                models.nextID = nextblog.bID;
            }

            if (prevblog != null)
            {
                models.previous = prevblog.btitle;
                models.previousID = prevblog.bID;
            }
            return models;
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
