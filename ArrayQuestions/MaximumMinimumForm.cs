using System;

public class MaximumMinimumForm
{
    public void Rearrange(int[] arr)
    {
        int n = arr.Length;
        int[] temp = new int[n];

        int small = 0;
        int large = n - 1;

        bool flag = true;

        for (int i = 0; i < n; i++)
        {
            if (flag)
            {
                temp[i] = arr[large];
                large--;
            }
            else
            {
                temp[i] = arr[small];
                small++;
            }
            flag = !flag;
            Array.Copy(temp, arr);
        }
    }

    public void RearrangeWithoutExtraSpace(int[] arr)
    {
        int n = arr.Length;
        int max_index = n - 1;
        int min_index = 0;
        int maxele = arr[max_index] + 1; // add one to the largest element. This will be the base


        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) // even index
            {
                arr[i] += (arr[max_index] % maxele) * maxele;
                max_index--;
            }
            else
            {
                arr[i] += (arr[min_index] % maxele) * maxele;
                min_index++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            arr[i] = arr[i] / maxele;
        }
    }


}
