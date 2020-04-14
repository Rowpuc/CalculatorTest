using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Model;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Repositories
{
    public interface IRepository
    {
        public Task<bool> Insert(Diagnostic diagnostic);
        public IQueryable<Diagnostic> SelectAll();
    }
}
