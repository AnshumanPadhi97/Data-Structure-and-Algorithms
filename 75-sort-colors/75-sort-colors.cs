public class Solution {
    public void SortColors(int[] nums) {
            int a = nums.Count(x => x == 0);
            int b = nums.Count(x => x == 1);
            int c = nums.Count(x => x == 2);

            for (int i = 0; i < a; i++) nums[i] = 0;
            for (int i = 0; i < b; i++) nums[i+a] = 1;
            for (int i = 0; i < c; i++) nums[i+a+b] = 2;
    }
}