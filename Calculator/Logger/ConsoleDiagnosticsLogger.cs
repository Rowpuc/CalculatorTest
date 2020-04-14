using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logger
{
    public class ConsoleDiagnosticsLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
