public class Solution {
    public string LargestNumber(int[] nums) {
        
        var arr = new string[nums.Length];
        
        for(int i = 0; i < nums.Length; i++){
            arr[i] = nums[i].ToString();
        }
        
        Comparer<string> comparer = Comparer<string>.Default;
        Array.Sort<string>(arr, (x, y) =>
        {
            string str1 = x + y;
            string str2 = y + x;
            return comparer.Compare(str1, str2);
        });
        
        if(arr[nums.Length-1] == "0")
            return "0";
        
        
        StringBuilder sb = new StringBuilder();
        for(int i = nums.Length-1; i >= 0; i--){
            sb.Append(arr[i]);
        }
        
        return sb.ToString();
    }
}