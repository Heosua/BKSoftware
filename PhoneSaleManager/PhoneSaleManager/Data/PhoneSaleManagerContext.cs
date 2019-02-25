using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhoneSaleManager.Models
{
    public class PhoneSaleManagerContext : DbContext
    {
        public PhoneSaleManagerContext (DbContextOptions<PhoneSaleManagerContext> options)
            : base(options)
        {
        }

        public DbSet<PhoneSaleManager.Models.Movie> Movie { get; set; }
    }
}
