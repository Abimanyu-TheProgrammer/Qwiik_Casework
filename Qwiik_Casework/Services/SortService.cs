using System;
namespace Qwiik_Casework.Services
{
	public class SortService : ISortService
	{

        public int[] runSort()
        {
            int[] l = new int[] { 3, 5, 8, 2, 4, 10, 6, 16, 23, 9, 11, 24 };
            var evenNums = from num in l where num % 2 == 0 select num;
            var newL = evenNums.ToArray();
            return Quicksort.Sort(newL, 0, newL.Length-1);
        }
    }
}

