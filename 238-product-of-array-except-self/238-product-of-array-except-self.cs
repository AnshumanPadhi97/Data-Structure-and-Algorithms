public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int l = nums.Length;
        var res = new int[l];
        
        Array.Fill(res, 1);
        int temp = 1;
        
        for (int i = 0; i < l; i++)
        {
            res[i] = temp;
            temp *= nums[i];
        }
        
        temp = 1;
        
        for (int i = l-1; i >= 0; i--)
        {
            res[i] *= temp;
            temp *= nums[i];
        }
        
        return res;
    }
}