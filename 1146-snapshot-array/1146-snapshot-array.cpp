class SnapshotArray {
public:
    int id=0;
    unordered_map<int,map<int,int>> m;
    SnapshotArray(int length) {
        
    }
    
    void set(int index, int val) {
        m[index][id]=val;
    }
    
    int snap() {
        return id++;
    }
    
    int get(int index, int snap_id) {
        auto it = m[index].upper_bound(snap_id);
        return it == begin(m[index]) ? 0 : prev(it)->second;
    }
};