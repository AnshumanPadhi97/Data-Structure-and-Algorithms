public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int l = nums.Length;
        var a = new int[l];
        nums.CopyTo(a,0);
        Array.Sort(a);
        int i=0,j=l-1;
        while(i<l && nums[i]==a[i]){
            i++;
        }
        while(j>i && nums[j]==a[j]){
            j--;
        }
        return j-i+1;
    }
}