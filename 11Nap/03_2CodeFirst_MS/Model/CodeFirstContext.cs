using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03CodeFirstCore.Models
{
    class CodeFirstContext : DbContext
    {
        protected override void OnConfigurating(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb\\MSSQLLocaldb; Database=Codefirst.db;trusted_Connection= true;)");
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
