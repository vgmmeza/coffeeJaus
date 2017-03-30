using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace coffeeJaus.Models
{
    public class CoffeeContext : DbContext
    {
        public CoffeeContext(DbContextOptions<CoffeeContext> options)
                : base(options) { }

        public DbSet<Stock> Stock { get; set; }
        public DbSet<Unit> Unit { get; set; }
    }
}
