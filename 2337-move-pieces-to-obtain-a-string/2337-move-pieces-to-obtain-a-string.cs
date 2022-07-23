public class Solution {
    public bool CanChange(string start, string target) {
            
            //check order
            if (!(start.Replace("_", "").Equals(target.Replace("_", "")))) return false;

            for (int i = 0, j = 0, n = start.Length; i < n && j < n; ++i, ++j)
            {
                while (i < n && start[i] == '_')
                {
                    i++;
                }
                while (j < n && target[j] == '_')
                {
                    j++;
                }
                //check positions
                if (i < n && j < n && ((start[i] == 'L' && i < j) || (target[j] == 'R' && i > j)))
                {
                    return false;
                }
            }
            return true;
    }
}