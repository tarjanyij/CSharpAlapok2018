using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03CodeFirstCore.Models
{
    public class CodeFirstContextFactory : IDesignTimeDbContextFactory<CodeFirstContext>
    {
        public CodeFirstContext CreateDbContext(string[] args)
        {
            var connectionString = "Server =.\\MSSQLLocalDB; Database =CodeFirstDB; Integrated Security = true;";

            var optionsBuilder = new DbContextOptionsBuilder<CodeFirstContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new CodeFirstContext(optionsBuilder.Options);

        }
    }
}
