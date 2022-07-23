public class Solution {
        public int NumMatchingSubseq(string s, string[] words)
        {
            var result = 0;
            var wordDict = new List<int>[26];
            h(s, wordDict);
            foreach (var word in words)
            {
                if (Present(wordDict, word))
                    result++;
            }
            return result;
        }
        void h(string s, List<int>[] wordDict)
        {
            for (int i = 0; i < s.Length; i++)
            {
                var index = s[i] - 'a';

                if (wordDict[index] == null) 
                    wordDict[index] = new List<int>();

                wordDict[index].Add(i);
            }
        }
        bool Present(List<int>[] wordDict, string word)
        {
            var lastIndex = -1;
            foreach (var ch in word)
            {
                var currList = wordDict[ch - 'a'];
                var index = BinarySearch(currList, lastIndex + 1);

                if (index == -1)
                    return false;

                if (currList[index] < lastIndex) 
                    return false;

                lastIndex = currList[index];
            }
            return true;
        }

        int BinarySearch(List<int> list, int val)
        {
            if (list == null || list.Count == 0) return -1;

            var index = list.BinarySearch(val);

            if (index >= 0) 
                return index;
            else
            {
                var comp = ~index;
                return comp >= list.Count ? -1 : comp;
            }
        }
}