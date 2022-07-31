public class NumArray {
    int[] bit = new int[0];
    int[] nums = new int[0];
    int n = 0;
    public NumArray(int[] a) {
        n = a.Length;
        bit = new int[n + 1];
        nums = a;
        for (int i = 0; i < n; i++)
        {
            init(i, nums[i]);
        }
    }
    public void init(int i,int val)
    {
        i++;
        while (i <= n)
        {
            bit[i] += val;
            i += (i & -i);
        }
    }
    public void Update(int index, int val) {
        var diff = val - nums[index];
        nums[index] = val;
        init(index, diff);
    }
    
    public int SumRange(int left, int right) {
        return getSum(right) - getSum(left - 1);
    }
    
    public int getSum(int i)
    {
        int sum = 0;
        i++;
        while (i > 0)
        {
            sum += bit[i];
            i -= (i & -i);
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */