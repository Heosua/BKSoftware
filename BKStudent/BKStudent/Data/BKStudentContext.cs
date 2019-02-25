using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BKStudent.Models
{
    public class BKStudentContext : DbContext
    {
        public BKStudentContext (DbContextOptions<BKStudentContext> options)
            : base(options)
        {
        }

        public DbSet<BKStudent.Models.Student> Student { get; set; }
    }
}
