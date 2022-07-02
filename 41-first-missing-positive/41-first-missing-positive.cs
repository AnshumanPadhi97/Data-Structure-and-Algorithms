public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var inList = new BitArray(int.MaxValue);
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= 0) 
                continue;

            inList[nums[i] - 1] = true;
        }
        var res = 1;
        for (var i = 0; i < inList.Length; i++)
            if (inList[i] == false) 
                return i + 1;
        return res;
    }
}