
    public class MyCircularQueue
    {
        int curSize = 0, size;
        List<int> ls;
        public MyCircularQueue(int k)
        {
            size = k;
            ls = new List<int>();
        }

        public bool EnQueue(int value)
        {
            if (IsFull()) return false;

            ls.Add(value);
            curSize++;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty()) return false;

            ls.RemoveAt(0);
            curSize--;
            return true;
        }

        public int Front()
        {
            return ls.FirstOrDefault(-1);
        }

        public int Rear()
        {
            return ls.LastOrDefault(-1);
        }

        public bool IsEmpty()
        {
            return curSize == 0;
        }

        public bool IsFull()
        {
            return size == curSize;
        }
    }