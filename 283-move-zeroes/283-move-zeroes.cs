public class Solution {
    public void MoveZeroes(int[] nums) {
        var ls = new List<int>();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                ls.Add(nums[i]);
            }
        }
        Array.Fill(nums,0);
        for(int i=0;i<ls.Count;i++){
            nums[i]=ls[i];
        }
    }
}