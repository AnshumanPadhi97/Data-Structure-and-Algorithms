/*
 You are given two 0-indexed integer arrays nums1 and nums2, both of length n.

You can choose two integers left and right where 0 <= left <= right < n and swap the subarray nums1[left...right] with the subarray nums2[left...right].

For example, if nums1 = [1,2,3,4,5] and nums2 = [11,12,13,14,15] and you choose left = 1 and right = 2, nums1 becomes [1,12,13,4,5] and nums2 becomes [11,2,3,14,15].
You may choose to apply the mentioned operation once or not do anything.

The score of the arrays is the maximum of sum(nums1) and sum(nums2), where sum(arr) is the sum of all the elements in the array arr.

Return the maximum possible score.
 */
public class Solution2321
{
    public int MaximumsSplicedArray(int[] nums1, int[] nums2)
    {
        //kadane on difference on both arrays
        int ans = 0, sum1 = 0, sum2 = 0;
        foreach (var item in nums1)
        {
            sum1 += item;
        }
        foreach (var item in nums2)
        {
            sum2 += item;
        }
        ans = Math.Max(sum1, sum2);

        int first = 0, second = 0, max1 = 0, max2 = 0;

        for (int i = 0; i < nums2.Length; i++)
        {
            first += (nums2[i] - nums1[i]);
            second += (nums1[i] - nums2[i]);

            max1 = Math.Max(max1, first);
            max2 = Math.Max(max2, second);

            if (first < 0) first = 0;
            if (second < 0) second = 0;
        }

        Console.WriteLine(max1);
        Console.WriteLine(max2);

        ans = Math.Max(ans, sum1 + max1);
        ans = Math.Max(ans, sum2 + max2);

        return ans;
    }
}