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

        /// <summary>
        /// Generate a fibonacci series up to {num}
        /// </summary>
        /// <param name="num"></param>
        /// <returns>an array of a fibonacci series</returns>
        [HttpGet("/fib/{num}")]
        public int[] showFib(int num)
        {
            return _fibonacciService.GenerateFibonacci(num);
        }

        /// <summary>
        /// Implementation of Queue, one of its usage would be
        /// FIFO task scheduling, in which the processes that comes first
        /// gets processed first.
        /// The implementation enqueues the integers 1 and 2, then dequeues 1
        /// </summary>
        /// <returns>a string that shows that what's left in the queue is 2</returns>
        [HttpGet("/queue")]
        public string showQueue()
        {
            return _queueService.runQueue();
        }

        /// <summary>
        /// Implementation of QuickSort.
        /// Sorts the filtered version of
        /// { 3, 5, 8, 2, 4, 10, 6, 16, 23, 9, 11, 24 };
        /// where we take only the even numbers.
        /// The time complexity is O(N log N)
        /// The space complexity is O(N)
        /// </summary>
        /// <returns>a sorted array</returns>
        [HttpGet("/sort")]
        public int[] showSort()
        {
            return _sortService.runSort();
        }

        /// <summary>
        /// Determines the type of a triangle by its three sides
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns>a string denoting the type</returns>
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

