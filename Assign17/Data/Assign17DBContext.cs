using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assign17.Models;

namespace Assign17.Data
{
    public class Assign17DBContext : DbContext
    {
        public Assign17DBContext (DbContextOptions<Assign17DBContext> options)
            : base(options)
        {
        }

        public DbSet<Assign17.Models.Movie> Movie { get; set; } = default!;
    }
}
