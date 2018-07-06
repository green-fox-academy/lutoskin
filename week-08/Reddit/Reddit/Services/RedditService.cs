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

        public void UpVote(int id)
        {
            var postThatIsUpVoted = GetPostById(id);
            postThatIsUpVoted.Votes++;
            redditContext.SaveChanges();
        }

        public void DownVote(int id)
        {
            var postThatIsDownVoted = GetPostById(id);
            postThatIsDownVoted.Votes--;
            redditContext.SaveChanges();
        }

        private RPost GetPostById(int id)
        {
            return redditContext.RPosts.Where(post => post.Id == id).First();
        }
    }
}
