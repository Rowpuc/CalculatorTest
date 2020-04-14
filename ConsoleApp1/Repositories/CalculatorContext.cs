using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Text;
using ConsoleApp.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Repositories
{
    public class CalculatorContext : DbContext
    {
        public CalculatorContext(DbContextOptions<CalculatorContext> options) : base (options)
        {

        }

        public DbSet<Diagnostic> Diagnostics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
