using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate.ProcessString(args[0]);
        }
    }
}
