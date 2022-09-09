class TrieNode {
public:
    bool end;
    TrieNode *c[26];
    
    TrieNode() {
        end = false;
        
        for (int i = 0; i < 26; i++)
            c[i] = NULL;
    }
};

class Trie {
public:
    TrieNode* root;
    
    Trie() {
        root = new TrieNode();
    }
    
    void insert(string word) {
        int word_len = word.length();
        TrieNode *cur = root;
        
        for (int i = 0; i < word_len; i++)
        {
            int k = word[i] - 'a';
            if (cur->c[k] == NULL)
            {
                cur->c[k] = new TrieNode();
            }
            cur = cur->c[k];
        }
        cur->end = true;
    }
    
    bool search(string word) {
        int word_len = word.length();
        TrieNode *cur = root;
        for (int i = 0; i < word_len; i++)
        {
            int k = word[i] - 'a';
            cur = cur->c[k];
            if (cur == NULL) return false;
        }        
        return cur->end;
    }
    
    bool startsWith(string prefix) {
        int word_len = prefix.length();
        TrieNode *cur = root;
        
        for (int i = 0; i < word_len; i++)
        {
            int k = prefix[i] - 'a';
            cur = cur->c[k];
            
            if (cur == NULL)
                return false;
        }
        
        return true;
    }
};

/**
 * Your Trie object will be instantiated and called as such:
 * Trie* obj = new Trie();
 * obj->insert(word);
 * bool param_2 = obj->search(word);
 * bool param_3 = obj->startsWith(prefix);
 */