public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        if(i<j  && j<k && nums[j] - nums[i] == diff && nums[k] - nums[j] == diff)
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
    }
}