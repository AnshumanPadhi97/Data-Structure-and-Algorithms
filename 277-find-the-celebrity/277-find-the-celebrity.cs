public class Solution : Relation {
        int a = 0;
        public int FindCelebrity(int n)
        {
            a = n;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (Knows(res, i)){
                    res = i;
                }
            }
            if (h(res))
            {
                return res;
            }
            return -1;
        }
        public bool h(int i)
        {
            for (int j = 0; j < a; j++)
            {
                if (i == j) continue;
                if(Knows(i,j) || !Knows(j, i))
                {
                    return false;
                }
            }
            return true;
        }
}