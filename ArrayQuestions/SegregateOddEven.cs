using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class SegregateOddEven
    {
        public void Segregate(int[] arr)
        {
            int n = arr.Length;
            int i = -1;
            int j = 0;
            while (j != n)
            {
                if (arr[j] % 2 == 0)
                {
                    ++i;
                    Swap(arr, i, j);
                }
                ++j;
            }

           
        }
        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
