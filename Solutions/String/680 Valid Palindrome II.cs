//Given a string s, return true if the s can be palindrome after deleting at most one character from it.

public class Solution680
{
    public bool ValidPalindrome(string s)
    {
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            if (s[i] != s[j])//first non match
            {
                return pallindrome(s, i, j - 1) || pallindrome(s, i + 1, j);
            }
            i++;
            j--;
        }
        return true;
    }
    public bool pallindrome(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j]) return false;
            i++; 
            j--;
        }
        return true;
    }
}