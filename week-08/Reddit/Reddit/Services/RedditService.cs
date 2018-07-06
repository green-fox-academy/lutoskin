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
    }
}
