public class Solution {
    public int MajorityElement(int[] nums) {
        int c=0;
        var res=0;
        foreach(var item in nums){
            if(c==0){
                res=item;
            }
            c+=res==item?1:-1;
        }
        return res;
    }
}