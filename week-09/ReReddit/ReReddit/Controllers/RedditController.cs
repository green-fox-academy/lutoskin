using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReReddit.Models;
using ReReddit.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReReddit.Controllers
{
    public class RedditController : Controller
    {
        private RedditService redditService;

        public RedditController(RedditService redditService)
        {
            this.redditService = redditService;
        }
        // GET: /<controller>/
        [HttpGet("/posts")]
        public IActionResult Index()
        {
            return Json(redditService.GetPosts());
        }

        [HttpPost("/posts")]
        public IActionResult AddPost([FromBody]Post post)
        {
            redditService.AddPost(post);
            return Json(post);
        }

        [HttpPost("/posts/{id}/upvote")]
        public IActionResult Upvote(int id)
        {
            redditService.UpVote(id);
            return Json(redditService.GetPostById(id));
        }

        [HttpPost("/posts/{id}/downvote")]
        public IActionResult Downvote(int id)
        {
            redditService.DownVote(id);
            return Json(redditService.GetPostById(id));
        }
    }
}
