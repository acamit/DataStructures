namespace Array
{
    internal class DeleteFromSortedArray
    {
        public int deleteElement(int[] arr, int n, int key)
        {
            int pos = binarySearch(arr, 0, n - 1, key);
            if (pos == -1)
            {
                return n;
            }

            for (int i = pos; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            return n - 1;
        }

        public int binarySearch(int[] a, int low, int high, int key)
        {
            if (high < low)
            {
                return -1;
            }

            int mid = (high + low) / 2;

            if (a[mid] == key)
            {
                return mid;
            }
            else if (key < a[mid])
            {
                return binarySearch(a, low, mid - 1, key);
            }
            else
            {
                return binarySearch(a, mid + 1, high, key);
            }
        }
    }
}
