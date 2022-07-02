public class Solution {
    public string FindDifferentBinaryString(string[] nums)
    {
        for (var i = 0; i <= Math.Pow(2, nums.Length); i++)
        {
            var a = ToBinaryString(i, nums.Length);
            if (!nums.Contains(a))
            {
                return a;
            }
        }
        return ToBinaryString(0, nums.Length);
    }

    private string ToBinaryString(int num, int digits)
    {
        var temp = Convert.ToString(num, 2);
        while (temp.Length < digits)
        {
            temp = "0" + temp;
        }
        return temp;
    }
}