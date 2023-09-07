using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Qwiik_Casework.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Qwiik_Casework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly IFibonacciService _fibonacciService;
        private readonly IQueueService _queueService;
        private readonly ISortService _sortService;
        private readonly ITriangleService _triangleService;

        public HomeController(IFibonacciService fibonacciService, IQueueService queueService, ISortService sortService, ITriangleService triangleService)
        {
            _fibonacciService = fibonacciService;
            _queueService = queueService;
            _sortService = sortService;
            _triangleService = triangleService;
        }

        [HttpGet("/fib/{num}")]
        public int[] showFib(int num)
        {
            return _fibonacciService.GenerateFibonacci(num);
        }

        [HttpGet("/queue")]
        public string showQueue()
        {
            return _queueService.runQueue();
        }

        [HttpGet("/sort")]
        public int[] showSort()
        {
            return _sortService.runSort();
        }

        [HttpGet("/triangle")]
        public string showTri(
            [FromQuery(Name = "first")] int first,
            [FromQuery(Name = "second")] int second,
            [FromQuery(Name = "third")] int third)
        {
            return _triangleService.TypeOfTriangle(first, second, third);
        }
    }
}

