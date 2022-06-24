using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6
{
    public class trie_template
    {
        public class Trie
        {
            TrieNode root { get; set; }

            class TrieNode
            {
                public TrieNode[] children { get; set; }
                public bool isEndOfWord { get; set; }
                public TrieNode()
                {
                    children = new TrieNode[26];
                    isEndOfWord = false;
                }
            }

            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string word)
            {
                var node = root;
                for (int i = 0; i < word.Length; i++)
                {
                    if (node.children[word[i] - 'a'] == null)
                    {
                        node.children[word[i] - 'a'] = new TrieNode();
                    }
                    node = node.children[word[i] - 'a'];
                }
                node.isEndOfWord = true;
            }

            public bool Search(string word)
            {
                var res = Find(word);
                return res == null ? false : res.isEndOfWord;
            }

            public bool StartsWith(string prefix)
            {
                return Find(prefix) != null;
            }

            //iterative search
            TrieNode Find(string word)
            {
                var node = root;
                for (int i = 0; i < word.Length; i++)
                {
                    if (node.children[word[i] - 'a'] == null)
                    {
                        return null;
                    }
                    node = node.children[word[i] - 'a'];
                }

                return node;
            }
            
            //dfs search
            bool search(string word, TrieNode parent, int i)
            {
                if (i == word.Length) return parent.isEndOfWord;

                var ind = word[i] - 'a';

                if (parent.children[ind] == null)
                {
                    return false;
                }

                return search(word, parent.children[ind], i+1);
            }
        }
    }
}
