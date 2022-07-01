public class RandomizedSet {
    
    HashSet<int> h = new HashSet<int>();
    
    public RandomizedSet() {
        
    }
    
    public bool Insert(int val) {
        if(!h.Contains(val)){
            h.Add(val);
            return true;
        }else{
            return false;
        }
    }
    
    public bool Remove(int val) {
        if(!h.Contains(val)){return false;}
        h.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        if(h.Count==0)return 0;
        Random r = new Random();
        int a = r.Next(h.Count);
        return h.ToArray()[a];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */