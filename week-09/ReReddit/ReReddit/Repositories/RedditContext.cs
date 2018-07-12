using Microsoft.EntityFrameworkCore;
using ReReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReReddit.Repositories
{
    public class RedditContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public RedditContext(DbContextOptions options) : base(options)
        {

        }
    }
}
