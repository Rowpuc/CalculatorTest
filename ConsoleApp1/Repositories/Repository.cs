using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Repositories
{
    public class Repository : IRepository
    {
        public CalculatorContext DbContext;

        public Repository(CalculatorContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<bool> Insert(Diagnostic diagnostic)
        {
            DbContext.Diagnostics.Add(diagnostic);
            await DbContext.SaveChangesAsync();
            return true;
        }

        public IQueryable<Diagnostic> SelectAll()
        {
            return DbContext.Diagnostics.AsQueryable();
        }
    }
}
