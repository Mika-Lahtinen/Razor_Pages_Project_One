using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Razor_Pages_Project_One.Models
{
    public class Razor_Pages_Project_OneContext : DbContext
    {
        public Razor_Pages_Project_OneContext (DbContextOptions<Razor_Pages_Project_OneContext> options)
            : base(options)
        {
        }

        public DbSet<Razor_Pages_Project_One.Models.Movie> Movie { get; set; }
    }
}
