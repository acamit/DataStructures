namespace Array
{
    internal class ReverseArray
    {
        public void reverseArray(int[] arr, int start, int end)
        {
            /*
             * Time Complexity - O(n)
             * Space Complexity - O(1)
            */
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;

            }
        }

        public void reverseArrayRecursive(int[] arr, int start, int end)
        {
            /*
             * Time Complexity - O(n)
             * Space Complexity - O(n)
            */
            if (start >= end)
            {
                return;
            }
            int temp;
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            reverseArrayRecursive(arr, start + 1, end - 1);

        }
    }
}
