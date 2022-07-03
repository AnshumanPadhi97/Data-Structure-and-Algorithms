public class Solution {
    public int WiggleMaxLength(int[] nums) {
        
            int l = nums.Length;
            if (l < 2) return l;

            int c = 0;
            int prev = nums[1] - nums[0];
            c = prev != 0 ? 2 : 1;

            for (int i = 2; i < l; i++)
            {
                var diff = nums[i] - nums[i - 1];
                if((prev<=0 && diff>0) || (prev>=0 && diff < 0))
                {
                    c++;
                    prev = diff;
                }
            }
            return c;
    }
}