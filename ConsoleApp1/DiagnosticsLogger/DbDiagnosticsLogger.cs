using ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Repositories;
using System.Threading.Tasks;

namespace ConsoleApp.DiagnosticsLogger
{
    public class DbDiagnosticsLogger : IDiagnosticsLogger
    {
        private readonly IRepository DiagnosticRepository;

        public DbDiagnosticsLogger(IRepository diagnosticRepository)
        {
            DiagnosticRepository = diagnosticRepository;
        }

        public async Task<bool> Log(Diagnostic diagnostic)
        {
            return await DiagnosticRepository.Insert(diagnostic);
        }
    }
}
