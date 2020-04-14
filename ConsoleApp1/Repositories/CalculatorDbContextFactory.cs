using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ConsoleApp.Repositories
{
    public class CalculatorDbContextFactory : IDesignTimeDbContextFactory<CalculatorContext>
    {
        public CalculatorContext CreateDbContext(string[] args)
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<CalculatorContext>();
            dbOptionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");
            return new CalculatorContext(dbOptionsBuilder.Options);
        }
    }
}
