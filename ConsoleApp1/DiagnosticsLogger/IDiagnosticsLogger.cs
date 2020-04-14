using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Model;

namespace ConsoleApp.DiagnosticsLogger
{
    public interface IDiagnosticsLogger
    {
        Task<bool> Log(Diagnostic diagnostic);
    }
}
