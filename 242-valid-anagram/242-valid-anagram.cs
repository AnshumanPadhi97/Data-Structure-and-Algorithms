public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] a = new int[26];
        foreach(var item in s)a[item-'a']++;
        foreach(var item in t)a[item-'a']--;
        foreach(var item in a){
            if(item!=0)return false;
        }
        return true;
    }
}