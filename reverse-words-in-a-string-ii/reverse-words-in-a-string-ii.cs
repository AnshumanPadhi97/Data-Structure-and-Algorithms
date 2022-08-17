public class Solution {
    public void ReverseWords(char[] s) {
        reverse(s,0,s.Length-1);
        int start=0,end=-1;
        for(int i=0;i<s.Length;i++){
            if(s[i]==' '){
                reverse(s,start,i-1);
                start=i+1;
            }
        }
        reverse(s,start,s.Length-1);
    }
    public void reverse(char[] s,int start,int end){
        while(start<end){
            var a = s[start];
            s[start]=s[end];
            s[end]=a;
            start++;
            end--;
        }
    }
}