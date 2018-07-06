using Microsoft.EntityFrameworkCore;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class RedditContext : DbContext
    {
        public DbSet<RPost> RPosts { get; set; }

        public RedditContext(DbContextOptions options) : base (options)
        {
        }

    }
}
