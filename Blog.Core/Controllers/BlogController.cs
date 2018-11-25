using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Core.Common.Helper;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    [Produces("application/json")]
    [Route("api/Blog")]
    //[Authorize(Policy = "Admin")]
    public class BlogController : Controller
    {
        IAdvertisementServices _advertisementServices;
        IBlogArticleServices _blogArticleServices;
        public BlogController(IAdvertisementServices advertisementServices, IBlogArticleServices blogArticleServices)
        {
            _advertisementServices = advertisementServices;
            _blogArticleServices = blogArticleServices;
        }

        // GET: api/Blog/5
        /// <summary>
        /// 根据id获取信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public async Task<List<Advertisement>> Get(int id)
        {
            return await _advertisementServices.Query(d => d.Id == id);
        }
        /// <summary>
        /// 获取博客列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetBlogs")]
        public async Task<List<BlogArticle>> GetBlogs()
        {
            //var connect = Appsettings.App(new string[] { "Appsettings", "RedisCaching", "ConnectionString" });
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
