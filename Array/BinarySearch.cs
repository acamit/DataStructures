namespace Array
{
    internal class BinarySearch
    {
        public static int binarySearch(int[] arr, int low, int high, int key)
        {
            if (high < low)
            {
                return -1;
            }
            int mid = (low + high) / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            if (key > arr[mid])
            {
                return binarySearch(arr, mid + 1, high, key);
            }
            else
            {
                return binarySearch(arr, low, mid - 1, key);
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 6, 7, 8, 9, 10 };

            int key = 10; // item to search

            int n = arr.Length;

            binarySearch(arr, 0, n - 1, key);
        }
    }
}
