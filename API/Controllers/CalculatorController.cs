using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator;
using API.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API
{
    [Route("api/calculations")]
    public class CalculatorController : Controller
    {
        public SimpleCalculator Calculator { get; set; }

        public CalculatorController()
        {
            Calculator = new SimpleCalculator();
        }
        // POST api/<controller>
        [HttpPost("add")]
        public HttpResult Add([FromBody] CalculationRequest request)
        {
            var result = Calculator.Add(request.firstNum, request.secondNum);
            return new HttpResult
            {
                Data = result,
                Message = "The addition calculation has been completed successfully.",
                Success = true
            };
        }

        // POST api/<controller>
        [HttpPost("subtract")]
        public HttpResult Subtract([FromBody] CalculationRequest request)
        {
            var result = Calculator.Subtract(request.firstNum, request.secondNum);
            return new HttpResult
            {
                Data = result,
                Message = "The subtraction calculation has been completed successfully.",
                Success = true
            };
        }

        // POST api/<controller>
        [HttpPost("divide")]
        public HttpResult Divide([FromBody] CalculationRequest request)
        {
            var result = Calculator.Divide(request.firstNum, request.secondNum);
            return new HttpResult
            {
                Data = result,
                Message = "The division calculation has been completed successfully.",
                Success = true
            };
        }

        // POST api/<controller>
        [HttpPost("multiply")]
        public HttpResult Multiply([FromBody] CalculationRequest request)
        {
            var result = Calculator.Multiply(request.firstNum, request.secondNum);
            return new HttpResult
            {
                Data = result,
                Message = "The multiplication calculation has been completed successfully.",
                Success = true
            };
        }
    }
}
