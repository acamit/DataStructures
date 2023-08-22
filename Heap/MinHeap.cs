namespace Heap
{
    internal class MinHeap
    {
        public int[] heapArray { get; set; }

        public int capacity { get; set; }

        public int current_heap_size { get; set; }

        public MinHeap(int n)
        {
            capacity = n;
            heapArray = new int[capacity];
            current_heap_size = 0;
        }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public int Parent(int k)
        {
            return (k - 1) / 2;
        }

        public int Left(int k)
        {
            return 2 * k + 1;
        }

        public int Right(int k)
        {
            return 2 * k + 2;
        }

        public bool InsertKey(int key)
        {
            if (current_heap_size == capacity)
            {
                return false;
            }

            // insert at end
            int i = current_heap_size;
            heapArray[i] = key;
            current_heap_size++;

            // Fix the main heap property if it is violated
            while (i != 0 && heapArray[i] < heapArray[Parent(i)])
            {
                Swap(ref heapArray[i], ref heapArray[Parent(i)]);
                i = Parent(i);
            }
            return true;
        }

        public void DecreaseKey(int key, int new_val)
        {
            // assign new value
            heapArray[key] = new_val;

            // move up as long as it is less than parent. 
            while (key != 0 && heapArray[key] < heapArray[Parent(key)])
            {
                Swap(ref heapArray[key], ref heapArray[Parent(key)]);
                key = Parent(key);
            }
        }

        public int getMin()
        {
            return heapArray[0];
        }

        public int ExtractMin()
        {
            if (current_heap_size <= 0)
            {
                return int.MaxValue;
            }
            if (current_heap_size == 1)
            {
                current_heap_size--;
                return heapArray[0];
            }
            int root = heapArray[0];
            heapArray[0] = heapArray[current_heap_size - 1];

            current_heap_size--;

            MinHeapify(0);

            return root;
        }

        private void MinHeapify(int key)
        {
            int l = Left(key);
            int r = Right(key);

            int smallest = key;
            if (l < current_heap_size
                && heapArray[l] < heapArray[smallest])
            {
                smallest = l;
            }

            if (r < current_heap_size
                && heapArray[r] < heapArray[smallest])
            {
                smallest = r;
            }
            // base condition for recursion
            if (smallest != key)
            {
                Swap(ref heapArray[key], ref heapArray[smallest]);
                MinHeapify(smallest);
            }
        }

        public void DeleteKey(int key)
        {
            DecreaseKey(key, int.MinValue);
            ExtractMin();
        }

        public void IncreaseKey(int key, int new_val)
        {
            heapArray[key] = new_val;
            MinHeapify(key);
        }

        public void ChangeValueOnKey(int key, int new_val)
        {
            if (heapArray[key] == new_val)
            {
                return;
            }
            if (heapArray[key] < new_val)
            {
                IncreaseKey(key, new_val);
            }
            else
            {
                DecreaseKey(key, new_val);
            }
        }
    }
}
