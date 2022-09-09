class Solution {
public:
    int longestNiceSubarray(vector<int>& nums) {
        int i=0,j=0,curr=0,res=1,l=nums.size();
		while (j<l)
		{
			while (i<l && (curr&nums[j])!=0)
			{
				curr^=nums[i++];
			}
			curr^=nums[j];
			res=max(res,j-i+1);
			j++;
		}
		
		return res;
    }
};