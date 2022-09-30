class Solution {
public:
    vector<vector<int>> getSkyline(vector<vector<int>>& buildings) {
        vector<vector<int>> res;
        multiset<int> q{0};
        
        vector<pair<int,int>> points;
        for (auto &&b : buildings)
        {
            points.push_back({b[0],-b[2]});    
            points.push_back({b[1],b[2]});    
        }
        
        sort(points.begin(),points.end());

        int ongoingHeight=0;

        for (int i = 0; i < points.size(); i++)
        {
            int currentPoint = points[i].first;
            int heightAtCurrentPoint = points[i].second;

            if(heightAtCurrentPoint<0){         //push start points
                q.insert(-heightAtCurrentPoint);
            }else{                              //erase end points
                q.erase(q.find(heightAtCurrentPoint));
            }

            auto qtop = *q.rbegin();
            if(ongoingHeight != qtop){
                ongoingHeight = qtop;
                res.push_back({currentPoint,ongoingHeight});
            }
        }       
        
        return res;
    }
};