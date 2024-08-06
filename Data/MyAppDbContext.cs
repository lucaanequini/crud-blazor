using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crudd.Models;

namespace crudd.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext (DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<crudd.Models.Product> Product { get; set; } = default!;
    }
}
