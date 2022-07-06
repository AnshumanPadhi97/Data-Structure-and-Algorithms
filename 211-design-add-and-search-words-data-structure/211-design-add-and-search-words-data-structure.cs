
        public class WordDictionary
        {
            public class node
            {
                public node[] c;
                public bool end;
                public node()
                {
                    c = new node[26];
                    end = false;
                }
            }
            public node root;
            public WordDictionary()
            {
                root = new node();
            }

            public void AddWord(string word)
            {
                var temp = root;
                foreach (var item in word)
                {
                    var ind = item - 'a';
                    if (temp.c[ind] == null)
                    {
                        temp.c[ind] = new node();
                    }
                    temp = temp.c[ind];
                }
                temp.end = true;
            }

            public bool Search(string word)
            {
                var temp = root;
                return find(word, temp, 0);
            }
            public bool find(string word, node par, int i)
            {
                if (i == word.Length) return par.end;
                var c = word[i];
                if (c != '.')
                {
                    var ind = c - 'a';
                    if (par.c[ind] == null) return false;
                    return find(word, par.c[ind], i+1);
                }
                else
                {
                    foreach (var item in par.c)
                    {
                        if (item != null)
                        {
                            if(find(word, item, i + 1))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }