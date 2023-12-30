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
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
    }
}
