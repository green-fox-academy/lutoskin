using ReReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReReddit.Repositories
{
    public class PostRepository
    {
        private RedditContext redditContext;

        public PostRepository(RedditContext redditContext)
        {
            this.redditContext = redditContext;
        }

        public List<Post> GetPosts()
        {
            return redditContext.Posts.ToList();
        }

        public void AddPost(Post post)
        {
            redditContext.Posts.Add(post);
            redditContext.SaveChanges();
        }

        public void UpVote(int id)
        {
            GetPostById(id).Score++;
            redditContext.SaveChanges();
        }

        public void DownVote(int id)
        {
            GetPostById(id).Score--;
            redditContext.SaveChanges();
        }

        public Post GetPostById(int id)
        {
            return redditContext.Posts.First(p => p.Id == id);         
        }
    }
}
