using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
    public static class Search
    {
        public static int binarySearch(int[] arr, int low, int high, int x)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                // Found it
                if (arr[mid] == x)
                {
                    return mid;
                }

                // Its on the left
                if (arr[mid] > x)
                {
                    return binarySearch(arr, low, mid - 1, x);
                }

                // Its on the right
                return binarySearch(arr, mid + 1, high, x);
            }

            // Its missing
            return -1;
        }
    }
}
