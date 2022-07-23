public class Solution {
        public int MinOperations(int[] nums, int[] numsDivide)
        {
            Array.Sort(nums);
            var a = numsDivide[0];
            foreach (var item in numsDivide)
            {
                a = gcd(item, a);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (a % nums[i] == 0) return i;
            }
            return -1;
        }
        int gcd(int a, int b)
        {
            if (a == 0)
                return b;

            return gcd(b % a, a);
        }
}