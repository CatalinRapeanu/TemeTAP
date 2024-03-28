using Microsoft.AspNetCore.Mvc;
using Lab4Web.Data;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLinqController : ControllerBase
    {
        private readonly ILinqService _linqService;

        public TestLinqController(ILinqService linqService)
        {
            _linqService = linqService;
            Data.Data.AddData();
        }

        [HttpGet("test-1")]
        public int Get(int age)
        {
            return _linqService.Test1(age);
        }
        
        [HttpGet("test-2")]
        public IEnumerable<Student> Test2(string faculty)
        {
            return _linqService.Test2(faculty);
        }
        
        [HttpGet("test-3")]
        public IEnumerable<string> Test3()
        {
            return _linqService.Test3();
        }
        
        [HttpGet("test-4")]
        public int Test4()
        {
            return _linqService.Test4();
        }
        
        [HttpGet("test-5")]
        public IEnumerable<Student> Test5(string faculty)
        {
            return _linqService.Test5(faculty);
        }
        
        [HttpGet("test-6")]
        public IEnumerable<IGrouping<string, Student>> Test6(string faculty)
        {
            return _linqService.Test6(faculty);
        }
    }
}
