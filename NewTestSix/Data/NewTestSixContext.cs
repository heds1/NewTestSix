using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewTestSix.Models;

namespace NewTestSix.Models
{
    public class NewTestSixContext : DbContext
    {
        public NewTestSixContext (DbContextOptions<NewTestSixContext> options)
            : base(options)
        {
        }

        public DbSet<NewTestSix.Models.Movie> Movie { get; set; }

        public DbSet<NewTestSix.Models.FormData> FormData { get; set; }

        public DbSet<NewTestSix.Models.SubmitFormV2> SubmitFormV2 { get; set; }
    }
}
