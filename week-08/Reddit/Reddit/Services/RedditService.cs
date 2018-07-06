using Reddit.Models;
using Reddit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class RedditService
    {
        private RedditContext redditContext;

        public RedditService(RedditContext redditContext)
        {
            this.redditContext = redditContext;
        }

        public List<RPost> GetRPosts()
        {
            return redditContext.RPosts.ToList();
        }

        public void AddRPosts(RPost rPost)
        {
            redditContext.RPosts.Add(rPost);
            redditContext.SaveChanges();
        }

        public void UpVote()
        {

        }

        public void DownVote()
        {

        }
    }
}
