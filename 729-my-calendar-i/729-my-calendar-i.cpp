class MyCalendar {
public:
    set<pair<int,int>> m;
    MyCalendar() {
        
    }
    
    bool book(int s, int e) {
        auto next = m.lower_bound({s,e}); // first element with key not go before k (i.e., either it is equivalent or goes after).
        
        // a existing booking started within the new booking (next)
        if(next != m.end() && next->first < e) return false;
        
        // new booking started within a existing booking (prev)
        if(next != m.begin() && s < (--next)->second) return false;
        
        m.insert({s,e});
            
        return true;
    }
};

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar* obj = new MyCalendar();
 * bool param_1 = obj->book(start,end);
 */