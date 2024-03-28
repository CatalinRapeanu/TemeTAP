using Lab4Web.Services.Lambda;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLambdaController : ControllerBase
    {
        private readonly ILambdaService _lambdaService;

        public TestLambdaController(ILambdaService lambdaService)
        {
            _lambdaService = lambdaService;
        }

        [HttpGet("test-1")]
        public string Get(int value)
        {
            var tupleValue = _lambdaService.Test1(value);
            return $"{tupleValue.Item1} / {tupleValue.Item2} / {tupleValue.Item3}";
        }

        [HttpGet("test-2")]
        public string Test2(string value)
        {
            return _lambdaService.Test2(value) ? "Number" : "Not number";
        }

        [HttpGet("test-3")]
        public string Test3(string value)
        {
            var result = _lambdaService.Test3Async(value).Result;
            return result;
        }
        
        [HttpGet("test-4")]
        public int Test4(int number1, int number2)
        {
            var result = _lambdaService.Test4Async(number1, number2).Result;
            return result;
        }
        
        [HttpGet("test-5")]
        public int Test5(int a = 21, int b = 34)
        {
            return _lambdaService.Test5(a, b);
        }
        
        [HttpGet("test-6")]
        public string Test6()
        {
            return _lambdaService.Test6Hello();
        }
        
        [HttpGet("test-7")]
        public string Test7Tuple2(string value)
        {
            var tupleValue = _lambdaService.Test7Tuple2(value);
            return $"{tupleValue.Item1} - {tupleValue.Item2} - {tupleValue.Item3}";
        }
        
        [HttpGet("test-8")]
        public string Test8(string value)
        {
            var result = _lambdaService.Test8(value).Result;
            return result;
        } 
        
        [HttpGet("test-9")]
        public string Test9()
        {
            return _lambdaService.Test9();
        } 
    }
}
