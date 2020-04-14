using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.Logger;
using ConsoleApp.Repositories;
using ConsoleApp.Model;
using ConsoleApp.Service;
using ConsoleApp.DiagnosticsLogger;

namespace ConsoleApp
{

    public class Calculate
    {
        private char[] OperatorChars = new char[] { '+', '-', '/', '*' };
        private readonly IDiagnosticsLogger LoggerService;
        private IRepository Repository;
        private readonly ICalculationService CalculationService;

        public Calculate(IDiagnosticsLogger loggerService, IRepository repository, ICalculationService calculationService)
        {
            LoggerService = loggerService;
            Repository = repository;
            CalculationService = calculationService;
        }

        public async Task Run()
        {
            Console.WriteLine("Enter an operation to perform in the form of [number] [operator] [number]:");
            string input = Console.ReadLine();
            while (!input.Equals("q"))
            {
                var result = await ProcessString(input);
                Console.WriteLine(result);

                Console.WriteLine("Enter an operation to perform in the form of [number] [operator] [number]:");
                input = Console.ReadLine();
            }
        }

        public async Task<int> ProcessString(string input)
        {
            try {
                var calculator = new SimpleCalculator();

                var operatorIndex = input.IndexOf(" ") + 1;
                var operatorChar = input.Substring(operatorIndex, 1);
                var firstNum = int.Parse(input.Substring(0, operatorIndex-1));
                var lastNum = int.Parse(input.Substring(operatorIndex + 2, input.Length - 2 - operatorIndex));

                HttpResult result;

                switch (operatorChar)
                {
                    case "+":
                        result = await CalculationService.Add(firstNum, lastNum);
                        break;
                    case "-":
                        result = await CalculationService.Subtract(firstNum, lastNum);
                        break;
                    case "/":
                        result = await CalculationService.Divide(firstNum, lastNum);
                        break;
                    case "*":
                        result = await CalculationService.Multiply(firstNum, lastNum);
                        break;
                    default:
                        throw new Exception();
                }
                // Log diagnostic result to DB
                await LoggerService.Log(new Diagnostic
                {
                    Data = result.Data,
                    Message = result.Message,
                    Success = result.Success
                });
                // Pull back all diagnostics for testing purposes
                var existingDiagnostics = Repository.SelectAll().ToList();

                return result.Data;
            } catch(Exception e)
            {
                // Log exception to DB
                await LoggerService.Log(new Diagnostic
                {
                    Message = e.Message,
                    Success = false
                });
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
