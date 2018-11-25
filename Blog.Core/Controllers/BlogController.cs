using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Core.Common.Redis;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    [Produces("application/json")]
    [Route("api/Blog")]
    [EnableCors("LimitRequests")]//允许跨域请求
    //[Authorize(Policy = "Admin")]
    public class BlogController : Controller
    {
        IAdvertisementServices _advertisementServices;
        IBlogArticleServices _blogArticleServices;
        IRedisCacheManager _redisCacheManager;
        public BlogController(IAdvertisementServices advertisementServices, IBlogArticleServices blogArticleServices, IRedisCacheManager redisCacheManager)
        {
            _advertisementServices = advertisementServices;
            _blogArticleServices = blogArticleServices;
            _redisCacheManager = redisCacheManager;
        }

        // GET: api/Blog/5
        /// <summary>
        /// 根据id获取信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public async Task<List<BlogArticle>> Get(int id)
        {
            List<BlogArticle> blogArticleList = new List<BlogArticle>();

            if (_redisCacheManager.Get<object>("Redis.Blog1") != null)
            {
                blogArticleList = _redisCacheManager.Get<List<BlogArticle>>("Redis.Blog1");
            }
            else
            {
                blogArticleList = await _blogArticleServices.Query(d => d.bID == id);
                _redisCacheManager.Set("Redis.Blog1", blogArticleList, TimeSpan.FromHours(2));//缓存2小时
            }

            return blogArticleList;
        }
        /// <summary>
        /// 获取博客列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetBlogs")]
        public async Task<List<BlogArticle>> GetBlogs()
        {
            return await _blogArticleServices.GetBlogs();
        }
        // POST: api/Blog
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Blog/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
