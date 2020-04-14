using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Model;

namespace ConsoleApp.Service
{
    public interface ICalculationService
    {
        public Task<HttpResult> Add(int start, int amount);
        public Task<HttpResult> Subtract(int start, int amount);
        public Task<HttpResult> Divide(int start, int amount);
        public Task<HttpResult> Multiply(int start, int amount);
    }
}
