using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WonderHorseStable.Models;

namespace WonderHorseStable.Repositories
{
    public class StableContext : DbContext
    {
        public DbSet<Horse> Horses { get; set; }
        public StableContext(DbContextOptions options) : base(options)
        {

        }
    }
}
