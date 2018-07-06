using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Services;

namespace Reddit.Controllers
{
    public class RedditController : Controller
    {
        private RedditService redditService;

        public RedditController(RedditService redditService)
        {
            this.redditService = redditService;
        }

        public IActionResult Trending()
        {
            return View(redditService.GetRPosts());
        }

        [HttpPost]
        public IActionResult UpVote(int id)
        {
            redditService.UpVote(id);
            return Redirect("Trending");
        }

        [HttpPost]
        public IActionResult DownVote(int id)
        {
            redditService.DownVote(id);
            return Redirect("Trending");
        }

        public IActionResult SubmitNewPost()
        {
            return View();
        }
    }
}