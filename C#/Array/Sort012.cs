namespace Array
{
    internal class Sort012
    {
        public void sort012(int[] arr, int n)
        {
            int low = 0;
            int mid = 0;
            int high = n;
            int temp;
            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        temp = arr[mid];
                        arr[mid] = arr[low];
                        arr[low] = temp;
                        low++;
                        mid++;
                        break;

                    case 1:
                        mid++;
                        break;

                    case 2:
                        temp = arr[high];
                        arr[high] = arr[mid];
                        arr[mid] = temp;
                        high--;
                        break;
                }
            }
            PrintArray(arr, n);
        }

        private void PrintArray(int[] arr, int n)
        {
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
