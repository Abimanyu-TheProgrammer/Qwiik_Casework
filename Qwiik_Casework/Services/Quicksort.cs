using System;
namespace Qwiik_Casework.Services
{
	public class Quicksort
	{
		public static int[] Sort(int[] array, int rightIndex, int leftIndex)
		{
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                Sort(array, leftIndex, j);
            if (i < rightIndex)
                Sort(array, i, rightIndex);

            return array;
        }
	}
}

