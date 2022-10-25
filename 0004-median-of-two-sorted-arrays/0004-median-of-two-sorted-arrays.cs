public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int a = nums1.Length;
        int b = nums2.Length;
        
        if(a>b){
            return FindMedianSortedArrays(nums2,nums1);
        }
        
        int low = 0, high = a;
        
        while(low<=high){
            
            int cut1 = (low+high)/2;
            int cut2 = (a+b+1)/2 - cut1;
            
            int l1 = cut1 == 0 ? int.MinValue : nums1[cut1-1];
            int l2 = cut2 == 0 ? int.MinValue : nums2[cut2-1];
            
            int r1 = cut1 == a ? int.MaxValue : nums1[cut1];
            int r2 = cut2 == b ? int.MaxValue : nums2[cut2];
            
            if(l1<=r2 && l2<=r1){
                if((a+b)%2==0){
                    return (Math.Max(l1,l2) + Math.Min(r1,r2)) / 2.0;
                }else{
                    return Math.Max(l1,l2);
                }
            }else if(l1>r2){
                high=cut1-1;
            }else{
                low=cut1+1;
            }
        }
        
        return 0.0;
    }
}