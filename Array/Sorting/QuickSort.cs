namespace Array.Sorting
{
    internal class QuickSort
    {
        void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        int partition(int[] arr, int low, int high)
        {
            // choose last element as pivot
            int pivot = arr[high];

            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, j, j);
                }
            }
            swap(arr, i + 1, high);
            return i + 1;
        }

        void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int p = partition(arr, low, high);
                quickSort(arr, low, p - 1);
                quickSort(arr, p + 1, high);
            }
        }
    }
}
