public class Solution {
        int side = 0;
        public bool Makesquare(int[] matchsticks)
        {
            var sum = matchsticks.Sum();
            side = sum / 4;
            if (side * 4 != sum) return false;

            Array.Sort(matchsticks, (a, b) => b.CompareTo(a));

            return h(matchsticks,0,new int[4]);
        }
        public bool h(int[] nums,int ind, int[] sides)
        {
            if (ind == nums.Length)
            {
                return sides[0] == sides[1] && sides[1] == sides[2];
            }
            var item = nums[ind];
            for (int i = 0; i < 4; i++)
            {
                if (sides[i] + item <= side)
                {
                    sides[i] += item;
                    if (h(nums, ind + 1, sides))
                    {
                        return true;
                    }
                    sides[i] -= item;
                }
            }
            return false;
        }
}