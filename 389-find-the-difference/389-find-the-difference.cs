public class Solution {
    public char FindTheDifference(string s, string t) {
        int[] a = new int[26];
        foreach(var item in s)a[item-'a']++;
        foreach(var item in t)a[item-'a']--;
        for(int i=0;i<26;i++){
            if(a[i]!=0)return (char)(i+97);
        }
        return '\n';
    }
}