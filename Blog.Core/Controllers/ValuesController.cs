using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy ="Admin")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">名称</param>
        /// <param name="age">年龄</param>
        /// <returns></returns>
        [HttpGet]
        public Love Get(string id,string name,string age)
        {
            return new Love() { Id = id, Name = name, Age = age };
        }

        // GET api/values/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
