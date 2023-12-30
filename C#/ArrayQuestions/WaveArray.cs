namespace ArrayQuestions
{
    internal class WaveArray
    {
        /// <summary>
        /// O(NlogN)

        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        void sortInWave(int[] arr, int n)
        {
            Array.Sort(arr);


            /*
             * [1, 2, 3, 4, 5]
             * [2, 1, 4, 3, 5]
             * 
             * [1, 2, 3, 4, 5, 6]
             * [2, 1, 4, 3, 6, 5]
             * 
             */
            // swap adjacent elements
            for (int i = 0; i < n - 1; i += 2)
            {
                swap(arr, i, i + 1);
            }
        }

        void swap(int[] arr, int a, int b)
        {
            (arr[a], arr[b]) = (arr[b], arr[a]);
        }

        // O(N)
        void SortInWave(int[] arr, int n)
        {
            for (int i = 0; i < n; i += 2)
            {
                if (i > 0 && arr[i] < arr[i - 1])
                {
                    swap(arr, i, i - 1);
                }

                if (i < n - 1 && arr[i] < arr[i + 1])
                {
                    swap(arr, i + 1, i);
                }
            }
        }
    }
}
