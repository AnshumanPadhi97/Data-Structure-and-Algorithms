public class Solution {
    public int[] FindOriginalArray(int[] changed) {
            Array.Sort(changed);

            if (changed.Length % 2 != 0) return new int[0];

            int mid = changed.Length / 2;

            int[] res = new int[mid];

            int[] freq = new int[100001];

            foreach (var item in changed)
            {
                freq[item]++;
            }

            int idx = 0;

            foreach (int no in changed)
            {
                if (freq[no] > 0 && no * 2 <= 100000 && freq[no * 2] > 0)
                {
                    freq[no]--;
                    freq[no * 2]--;
                    res[idx++] = no;
                }
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0) return new int[0];
            }

            return res;
    }
}