namespace Array.Sorting
{
    internal class HeapSort
    {
        public void Sort(int[] arr)
        {
            int N = arr.Length;

            // build a heap from array
            for (int i = N / 2 - 1; i >= 0; i--)
            {
                heapify(arr, N, i);
            }

            for (int i = N - 1; i >= 0; i--)
            {
                // 0 is considered to be root all the time.
                // extract min mock
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                //heapify on remaining heap. 
                heapify(arr, i, 0);
            }
        }

        void heapify(int[] arr, int N, int i)
        {
            int largest = i;

            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < N && arr[l] > arr[largest])
            {
                largest = l;
            }

            if (r < N && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                heapify(arr, N, largest);
            }
        }
    }
}
