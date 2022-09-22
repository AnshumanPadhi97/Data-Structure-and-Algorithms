class Solution {
public:
    int maximizeSweetness(vector<int>& sweetness, int k) {
        int people = k+1;
        int left = *min_element(sweetness.begin(),sweetness.end());
        int right = accumulate(sweetness.begin(),sweetness.end(),0)/people;
        while (left<right)
        {
            int mid = (left+right+1)/2;
            int curr=0;
            int peopleWithChocolate=0;
            for (auto &&i : sweetness)
            {
                curr+=i;
                if(curr>=mid){
                    peopleWithChocolate++;
                    curr=0;
                }
            }
            if(peopleWithChocolate>=people){
                left=mid;
            }else{
                right=mid-1;
            }
        }
        return right;
    }
};