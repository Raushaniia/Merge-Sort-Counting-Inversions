using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge
{
    class Program
    {
        static long countInversions(int[] arr, int n)
        {
            // Complete this function
            return Merge(arr, 0, arr.Length - 1);
        }
        public static long Merge(int[] array, int start, int end)
        {
            long count = 0;
            if (start == end)
            {
                return 0;
            }
            int mid = (start + end) / 2;
            count += Merge(array, start, mid);
            count += Merge(array, mid + 1, end);
            count += Sort(array, start, end);
            return count;

        }
        public static long Sort(int[] array, int start, int end)
        {
            long count = 0;
            int mid = (start + end) / 2;
            int[] newArray = new int[end - start + 1];
            int i = start;
            int j = mid + 1;
            int marker = 0;
            while (i <= mid && j <= end)
            {
                if (array[i] > array[j])
                {
                    newArray[marker++] = array[j++];
                    count += mid - i + 1;
                }
                else
                {
                    newArray[marker++] = array[i++];
                }
            }
            while (i <= mid)
            {
                newArray[marker++] = array[i++];
            }

            while (j <= end)
            {
                newArray[marker++] = array[j++];
            }
            System.Array.Copy(newArray, 0, array, start, end - start + 1);
            return count;
        }

        static void Main(String[] args)
        {int n = 5;
                
                int[] arr = { 2, 1, 3, 1, 2, };
                long result = countInversions(arr, n);
                Console.WriteLine(result);
            Console.ReadLine();
          
        }
    }
}
