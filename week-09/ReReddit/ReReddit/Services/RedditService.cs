using ReReddit.Models;
using ReReddit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReReddit.Services
{
    public class RedditService
    {
        private PostRepository postRepository;

        public RedditService(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public List<Post> GetPosts()
        {
            return postRepository.GetPosts();
        }

        public void AddPost(Post post)
        {
            postRepository.AddPost(post);
        }

        public void UpVote(int id)
        {
            postRepository.UpVote(id);
        }

        public void DownVote(int id)
        {
            postRepository.DownVote(id);
        }

        public Post GetPostById(int id)
        {
            return postRepository.GetPostById(id);
        }
    }
}
