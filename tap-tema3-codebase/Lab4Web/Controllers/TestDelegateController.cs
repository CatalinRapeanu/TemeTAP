using Lab4Web.Services.Delegate;
using Microsoft.AspNetCore.Mvc; 

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDelegateController : ControllerBase
    {
        private readonly IDelegateService _delegateService;

        public TestDelegateController(IDelegateService delegateService)
        {
            _delegateService = delegateService; 
        }

        [HttpGet("Welcome")]
        public string Test1(string name)
        {
            //o metoda in alta metoda
            var callback = _delegateService.Welcome;
            return _delegateService.Introduction(name, callback);
        }

        [HttpGet("Requirements")]
        public string Test2(string name, int age)
        { 
            //o metoda cu conditie impusa
            var callback1 = _delegateService.MinimumRequirements; 
             
            var callback = age >= 18 ? (name) => $"Congratulations, {name}, you meet the minimum requirements." : callback1;

            return _delegateService.Introduction(name, callback);
        }
        
        [HttpGet("Bye")]
        public string Test3(string name, bool active)
        {
            var callback1 = (string name) => $"Bye, {name}.";
            var callback2 = (string name) => $"{name} is still active.";
             
            var callback = active ? callback2 : callback1;

            return _delegateService.Introduction(name, callback);
        } 
    }
}
