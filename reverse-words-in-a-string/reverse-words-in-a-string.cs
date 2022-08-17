public class Solution {
    public string ReverseWords(string s) {
        return string.Join(' ', s.Split(' ').Reverse().Where(e => e.Length > 0));
    }
}