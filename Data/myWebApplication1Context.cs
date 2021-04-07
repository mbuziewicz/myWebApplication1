using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myWebApplication1.Models;

namespace myWebApplication1.Data
{
    public class myWebApplication1Context : DbContext
    {
        public myWebApplication1Context (DbContextOptions<myWebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<myWebApplication1.Models.Student> Student { get; set; }
    }
}
