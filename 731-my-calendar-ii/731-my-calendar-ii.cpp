class MyCalendarTwo {
public:
    map<int,int>m;
    MyCalendarTwo() {
        
    }
    
    bool book(int s, int e) {
        m[s]++;
        m[e]--;
        int c=0;
        for(auto i:m){
            c+=i.second;
            if(c==3){//intersection of 3 dates
                m[s]--;
                m[e]++;
                return false;
            }
        }
        return true;
    }
};