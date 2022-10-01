class LUPrefix {
public:
    set<int> s;
    int max=0;
    LUPrefix(int n) {
        
    }
    
    void upload(int video) {
        s.insert(video);
        while (s.find(max+1)!=s.end())
        {
            max++;
        }
            
    }
    
    int longest() {
        return max;
    }
};