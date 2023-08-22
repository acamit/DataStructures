using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    class SortByValue : IComparer<KeyValuePair<int, int>>
    {
        public int Compare(KeyValuePair<int, int> o1, KeyValuePair<int, int> o2)
        {
            if (o1.Value == o2.Value)
            {
                return o1.Key - o2.Key;
            }
            return o1.Value - o2.Value;
        }
    }
    public class SortByFrequency
    {
        public List<int> sortByFrequency(int[] arr, int n)
        {
            Dictionary<int, int> m = new Dictionary<int, int>();
            List<int> res = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x = arr[i];
                if (m.ContainsKey(x))
                {
                    m[x]++;
                }
                else
                {
                    m.Add(x, 1);
                }
            }

            // copy dictionary to list. insertion is fast and helps in sorting
            List<KeyValuePair<int, int>> v = new List<KeyValuePair<int, int>>(m);

            v.Sort(new SortByValue());

            foreach (KeyValuePair<int, int> kvp in v)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    res.Add(kvp.Key);
                }
            }
            return res;
        }
    }
}
