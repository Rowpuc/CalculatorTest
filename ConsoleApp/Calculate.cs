using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace ConsoleApp
{

    public static class Calculate
    {
        private static char[] OperatorChars = new char[] { '+', '-', '/', '*' };

        public static int ProcessString(string input)
        {
            var calculator = new SimpleCalculator();

            var operatorIndex = Array.IndexOf(OperatorChars, input);
            var operatorChar = input.Substring(operatorIndex, operatorIndex);
            var firstNum = int.Parse(input.Substring(0, operatorIndex));
            var lastNum = int.Parse(input.Substring(operatorIndex, input.Length-1));

            switch (operatorChar)
            {
                case "+":
                    return calculator.Add(firstNum, lastNum);
                case "-":
                    return calculator.Subtract(firstNum, lastNum);
                case "/":
                    return calculator.Divide(firstNum, lastNum);
                case "*":
                    return calculator.Multiply(firstNum, lastNum);
                default:
                    return -1;
            }
        }
    }
}
