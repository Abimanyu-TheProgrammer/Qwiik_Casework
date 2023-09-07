using System;
namespace Qwiik_Casework.Services
{
	public class SortService : ISortService
	{

        public int[] runSort()
        {
            int[] l = new int[] { 3, 5, 8, 2, 4 };
            return Quicksort.Sort(l, 0, l.Length-1);

        }
    }
}

