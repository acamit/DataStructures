namespace Array
{
    internal class LargestSumContiguousSubarray
    {
        public int largestSumContiguousSubarray(int[] arr)
        {
            /*
             * Time Complexity - O(n)
             * Space Complexity - O(1)
            */
            int size = arr.Length;
            int max_so_far = int.MinValue;
            int max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + arr[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                }
                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                }
            }

            return max_so_far;
        }

        public void printLargestSumContiguousSubarray(int[] a)
        {
            int max_so_far = int.MinValue;
            int max_ending_here = 0;
            int start = 0, end = 0, s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                max_ending_here += a[i];
                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    s = i + 1;
                }
            }

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

    }
}
