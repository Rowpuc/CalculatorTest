using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Logger;

namespace Calculator
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public ILogger Logger;

        public SimpleCalculator()
        {
            Logger = new ConsoleDiagnosticsLogger();
        }

        public int Add(int start, int amount)
        {
            var result = start + amount;
            Logger.Log(result.ToString());

            return result;
        }

        public int Divide(int start, int by)
        {
            var result = start / by;
            Logger.Log(result.ToString());

            return result;
        }

        public int Multiply(int start, int by)
        {
            var result = start * by;
            Logger.Log(result.ToString());

            return result;
        }

        public int Subtract(int start, int amount)
        {
            var result = start - amount;
            Logger.Log(result.ToString());

            return result;
        }
    }
}
