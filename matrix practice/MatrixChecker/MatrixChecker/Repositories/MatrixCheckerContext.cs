using MatrixChecker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixChecker.Repositories
{
    public class MatrixCheckerContext : DbContext
    {      
        public DbSet<Matrix> Matrices { get; set; }

        public MatrixCheckerContext(DbContextOptions options) : base(options)
        {

        }
    }
}
