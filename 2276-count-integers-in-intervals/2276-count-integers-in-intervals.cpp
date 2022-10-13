class CountIntervals {
public:
    set<pair<int,int>> s;
    int c;
    CountIntervals() {
        c=0;
    }
    
    void add(int left, int right) {
        auto it = s.upper_bound({left,right});
        if(it!=s.begin() && (--it)->second<left){
            it++;
        }
        while (it != s.end() && it->first <= right)
        {
            left = min(left,it->first);
            right = max(right,it->second);
            c-=(it->second - it->first + 1);
            it=s.erase(it);
        }
        s.insert({left,right});
        c+=(right-left+1);
    }
    
    int count() {
        return c;
    }
};