class Solution {
public:
    int carFleet(int target, vector<int>& position, vector<int>& speed) {
        map<int,double> m;
        for (int i = 0; i < position.size(); i++)
        {
            double d = (double)(target-position[i])/speed[i];
            m[position[i]]=d;
        }
        int res=0;
        double time=0;
        for (auto it = m.rbegin(); it != m.rend(); it++)
        {
            if(time < it->second){
                res++;
                time=it->second;
            }
        }        
        return res;
    }
};