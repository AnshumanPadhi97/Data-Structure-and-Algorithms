public class Solution {
    public bool CircularArrayLoop(int[] nums) {
        
        for(int i=0;i<nums.Length;i++){
            
            bool forward = nums[i]>=0;
            int s=i,f=i;            
            
            do{
                s=next(nums,forward,s);
                f=next(nums,forward,f);
                if(f!=-1){
                    f=next(nums,forward,f);
                }
            }while(s!=-1 && f!=-1 && s!=f);
            
            if(s==f && s!=-1)return true;
        }
        
        return false;
    }
    public int next(int[] nums,bool f,int i){
        
        bool dir = nums[i]>=0;
        
        if(f!=dir)
            return -1;
        
        var n = (nums[i]+i)%nums.Length;
        if(n<0){
            n+=nums.Length;
        }
        
        if(i==n)return -1;
        
        return n;
    }
}