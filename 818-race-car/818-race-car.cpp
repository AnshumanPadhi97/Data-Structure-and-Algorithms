class Solution {
public:
    int racecar(int target) {
        queue<vector<int>> q;
        q.push({0,0,1});
        while (!q.empty())
        {
            vector<int> item = q.front();
            q.pop();

            int moves = item[0];
            int pos = item[1];
            int vel = item[2];

            if(pos==target)return moves;
            if(abs(pos)>2*target)continue;

            q.push({moves+1,pos+vel,vel*2});

            //Only consider changing the direction of the car
            //    i.  The car is driving away from the target.
            //    ii. The car will pass the target in the next move. 
            if((pos + vel > target && vel>0) || (pos+vel<target && vel<0)){
                q.push({moves+1,pos,(vel>0)?-1:1});
            }
        }
        return 0;
    }
};