using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Model;
using Newtonsoft.Json;
using RestSharp;

namespace ConsoleApp.Service
{
    public class CalculationService : ICalculationService
    {
        private string Endpoint;
        private RestClient RestClient;

        public CalculationService()
        {
            Endpoint = "https://localhost:5001/api/calculations/";
            RestClient = new RestClient(new Uri(Endpoint));
        }

        public async Task<HttpResult> Add(int start, int amount)
        {
            var request = new RestRequest("add/", Method.POST)
            {
                Parameters =
                {
                    new Parameter("Content-Type", "application/json", ParameterType.HttpHeader),
                },
            };
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(new HttpRequest { FirstNum = start, SecondNum = amount }), ParameterType.RequestBody);

            var response = await RestClient.ExecuteAsync(request);

            var httpResult = JsonConvert.DeserializeObject<HttpResult>(response.Content);

            return httpResult;
        }

        public async Task<HttpResult> Subtract(int start, int amount)
        {
            var request = new RestRequest("subtract/", Method.POST)
            {
                Parameters =
                {
                    new Parameter("Content-Type", "application/json", ParameterType.HttpHeader),
                },
            };
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(new HttpRequest { FirstNum = start, SecondNum = amount }), ParameterType.RequestBody);

            var response = await RestClient.ExecuteAsync(request);

            var httpResult = JsonConvert.DeserializeObject<HttpResult>(response.Content);

            return httpResult;
        }

        public async Task<HttpResult> Divide(int start, int by)
        {
            var request = new RestRequest("divide/", Method.POST)
            {
                Parameters =
                {
                    new Parameter("Content-Type", "application/json", ParameterType.HttpHeader),
                },
            };
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(new HttpRequest { FirstNum = start, SecondNum = by }), ParameterType.RequestBody);

            var response = await RestClient.ExecuteAsync(request);

            var httpResult = JsonConvert.DeserializeObject<HttpResult>(response.Content);

            return httpResult;
        }

        public async Task<HttpResult> Multiply(int start, int by)
        {
            var request = new RestRequest("multiply/", Method.POST)
            {
                Parameters =
                {
                    new Parameter("Content-Type", "application/json", ParameterType.HttpHeader),
                },
            };
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(new HttpRequest { FirstNum = start, SecondNum = by }), ParameterType.RequestBody);

            var response = await RestClient.ExecuteAsync(request);

            var httpResult = JsonConvert.DeserializeObject<HttpResult>(response.Content);

            return httpResult;
        }
    }
}
