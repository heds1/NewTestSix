using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewTestSix.Models
{
    public class NewTestSixContext : DbContext
    {
        public NewTestSixContext (DbContextOptions<NewTestSixContext> options)
            : base(options)
        {
        }

        public DbSet<NewTestSix.Models.Movie> Movie { get; set; }
    }
}
