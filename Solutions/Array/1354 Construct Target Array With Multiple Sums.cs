/*
     You are given an array target of n integers. From a starting array arr consisting of n 1's, you may perform the following procedure :

    let x be the sum of all elements currently in your array.
    choose index i, such that 0 <= i < n and set the value of arr at index i to x.
    You may repeat this procedure as many times as needed.
    Return true if it is possible to construct the target array from arr, otherwise, return false.
 */
public class Solution1354
{
    public bool IsPossible(int[] target)
    {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        long sum = 0;
        foreach (var item in target)
        {
            sum += item;
            pq.Enqueue(item, item);
        }

        while (pq.Peek() != 1)
        {
            var a = pq.Dequeue();
            long other = sum - a;

            if (other == 0 || other >= a || (other != 1 && (long)a % other == 0))
            {
                return false;
            }

            a = a % (int)other;
            sum = other + a;
            pq.Enqueue(a, a);
        }
        return true;
    }
}