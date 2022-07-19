
    public class MedianFinder
    {
        PriorityQueue<int, int> maxHeap;
        PriorityQueue<int, int> minHeap;
        public MedianFinder()
        {
            minHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
            maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => a - b));
        }

        public void AddNum(int num)
        {
            if (minHeap.Count == 0 || minHeap.Peek() >= num)
            {
                minHeap.Enqueue(num, num);
            }
            else
            {
                maxHeap.Enqueue(num, num);
            }
            if (minHeap.Count > maxHeap.Count + 1)
            {
                var a = minHeap.Dequeue();
                maxHeap.Enqueue(a, a);
            }
            else if (maxHeap.Count > minHeap.Count + 1)
            {
                var a = maxHeap.Dequeue();
                minHeap.Enqueue(a, a);
            }
        }

        public double FindMedian()
        {
            if (maxHeap.Count == minHeap.Count)
            {
                return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
            }
            else if (maxHeap.Count > minHeap.Count)
            {
                return maxHeap.Peek();
            }
            else
            {
                return minHeap.Peek();
            }
        }
    }