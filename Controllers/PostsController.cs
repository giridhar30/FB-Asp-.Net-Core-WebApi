using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

using FbBackend.Models;
using FbBackend.Data;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FbBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class PostsController : ControllerBase
    {
        private FbContext _ctx;

        public PostsController(FbContext ctx)
        {
            _ctx = ctx;
        }

        // GET: api/<PostsController>
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _ctx.Posts;
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostsController>
        [HttpPost]
        public object Post(Post post)
        {
            try
            {
                _ctx.Posts.Add(post);
                _ctx.SaveChangesAsync();
                return post;
            } catch(Exception e)
            {
                Console.WriteLine(e);
                return e.ToString();
            }
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
