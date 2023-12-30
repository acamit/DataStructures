namespace Array.Sorting
{
    internal class MergeSort
    {
        void merge(int[] arr, int l, int m, int r)
        {
            // size of first subarray include m element
            int n1 = m - l + 1;

            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i, j;

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] < R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                k++;
                j++;
            }
        }

        void sort(int[] arr, int l, int r)
        {
            int m = l + (r - l) / 2;
            // sort first and second half
            sort(arr, l, m);
            sort(arr, m + 1, r);

            // merge sroted halfs
            merge(arr, l, m, r);
        }
    }
}
