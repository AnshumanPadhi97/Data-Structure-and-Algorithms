/*
 * Given a sorted integer array arr, two integers k and x, return the k closest integers to x in the array. The result should also be sorted in ascending order.

    An integer a is closer to x than an integer b if:

    |a - x| < |b - x|, or
    |a - x| == |b - x| and a < b
 */
public class Solution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        var result = new List<int>();
        if (arr == null || arr.Length == 0)
        {
            return result;
        }

        var maxHeap = new PriorityQueue<int, int>(new ModComparer(x));
        for (int i = 0; i < arr.Length; i++)
        {
            maxHeap.Enqueue(arr[i], arr[i]);
            if (maxHeap.Count > k)
            {
                maxHeap.Dequeue();
            }
        }

        while (maxHeap.Count != 0)
        {
            result.Add(maxHeap.Dequeue());
        }
        result.Sort();
        return result;
    }
    public class ModComparer : IComparer<int>
    {
        int x;
        public ModComparer(int x)
        {
            this.x = x;
        }
        public int Compare(int a, int b)
        {
            var d1 = Math.Abs(a - x);
            var d2 = Math.Abs(b - x);
            if (d1 != d2)
            {
                return d2 - d1;
            }
            return b - a;
        }
    }
}