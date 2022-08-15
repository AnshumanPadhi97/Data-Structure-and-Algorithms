class Twitter {
public:

    unordered_map<int,set<int>> ft;
    unordered_map<int,vector<pair<int,int>>> t;

    long long time;

    Twitter() {
        time=0;
    }
    
    void postTweet(int userId, int tweetId) {
        t[userId].push_back({time++,tweetId});
    }
    
    vector<int> getNewsFeed(int userId) {
        priority_queue<pair<int,int>> pq;
        
        for (auto &&i : t[userId])
        {
            pq.push(i);    
        }

        for (auto &&i : ft[userId])
        {
            for (auto &&j : t[i])
            {
                pq.push(j);       
            }            
        }

        vector<int> res;
        while (!pq.empty())
        {
            res.push_back(pq.top().second);
            if(res.size()==10)break;
            pq.pop();
        }
        
        return res;
    }
    
    void follow(int followerId, int followeeId) {
        if(followeeId!=followerId){
            ft[followerId].insert(followeeId);
        }
    }
    
    void unfollow(int followerId, int followeeId) {
        ft[followerId].erase(followeeId);
    }
};