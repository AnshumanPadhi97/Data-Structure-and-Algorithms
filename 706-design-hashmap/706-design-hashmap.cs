public class MyHashMap {
    int[] a = new int[1000001];
    public MyHashMap() {
        Array.Fill(a,-1);
    }
    
    public void Put(int key, int value) {
        a[key]=value;
    }
    
    public int Get(int key) {
        return a[key];
    }
    
    public void Remove(int key) {
        a[key]=-1;
    }
}