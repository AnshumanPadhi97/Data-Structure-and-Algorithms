public class Solution {
    public string RemoveDigit(string number, char digit) {
            List<string> digits = new List<string>();
            for(int i = 0; i < number.Length; i++)
            {
                if(number[i]== digit)
                {
                    digits.Add(number.Substring(0,i)+number.Substring(i+1));
                }
            }
            digits.Sort();
            return digits.Last();
    }
}