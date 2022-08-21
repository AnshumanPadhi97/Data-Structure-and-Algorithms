class Solution {
public:
    int findRadius(vector<int>& houses, vector<int>& heaters) {
        
        int l = houses.size();
        sort(houses.begin(),houses.end());
        sort(heaters.begin(),heaters.end());

        vector<int> d(l,1e9+7);

        for (int i = 0, h=0; i < houses.size() && h < heaters.size();)
        {
            if(houses[i]<=heaters[h]){
                d[i] = heaters[h]-houses[i];
                i++;
            }else{
                h++;
            }
        }

        for (int i = houses.size()-1, h = heaters.size() - 1; i >=0 && h >= 0;)
        {
            if(houses[i]>=heaters[h]){
                d[i]=min(d[i],houses[i]-heaters[h]);
                i--;
            }else{
                h--;
            }
        }

        return *max_element(d.begin(),d.end());
    }
};