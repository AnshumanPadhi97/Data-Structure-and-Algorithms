public class Solution {
    public int[] SumPrefixScores(string[] words)
    {
        Trie trie = new Trie();
        foreach (string word in words)
        {
            trie.Insert(word);
        }

        int n = words.Length;
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = trie.Count(words[i]);
        }
        return result;
    }
    
    private class Trie
    {
        public class TrieNode
        {
            public TrieNode[] children = new TrieNode[26];
            public int count;
        }

        public TrieNode root = new TrieNode();
        public void Insert(string str)
        {
            TrieNode node = root;
            for (int i = 0; i < str.Length; i++)
            {
                int index = str[i] - 'a';
                if (node.children[index] == null){
                    node.children[index] = new TrieNode();
                }
                node = node.children[index];
                node.count++;
            }
        }

        public int Count(string str)
        {
            int result = 0;
            TrieNode node = root;
            for (int level = 0; level < str.Length; level++)
            {
                int index = str[level] - 'a';
                node = node.children[index];
                result += node.count;
            }
            return result;
        }
    }
}