public class Solution {
    List<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> Subsets(int[] nums) {
        Array.Sort(nums);
        res = new List<IList<int>>();
        subsets(nums,0,new List<int>());
        return res;
    }    
    public void subsets(int[] a,int i, List<int> temp)
    {
        if (i == a.Length)
        {
            res.Add(temp.ToList());
            return;
        }

        subsets(a, i + 1, temp);

        if (i > 0 && a[i] == a[i - 1]) return;
        temp.Add(a[i]);

        subsets(a, i + 1, temp);
        temp.RemoveAt(temp.Count - 1);
    }
}