
        public class RandomizedCollection
        {
            List<int> a = new List<int>();
            Dictionary<int, HashSet<int>> b = new Dictionary<int, HashSet<int>>();
            public RandomizedCollection()
            {

            }

            public bool Insert(int val)
            {
                var result = false;
                if (!b.ContainsKey(val))
                {
                    b[val] = new HashSet<int>();
                    result = true;
                }
                a.Add(val);     
                b[val].Add(a.Count - 1);
                return result;
            }

            public bool Remove(int val)
            {
                if (!b.ContainsKey(val))
                {
                    return false;
                }
                var lastItemIndex = a.Count - 1;
                var itemToRemoveIndex = b[val].First();
                b[val].Remove(itemToRemoveIndex);
                if (itemToRemoveIndex != lastItemIndex)
                {
                    var needToModifyItem = a[lastItemIndex];     
                    a[itemToRemoveIndex] = needToModifyItem;
                    b[needToModifyItem].Add(itemToRemoveIndex);
                    b[needToModifyItem].Remove(lastItemIndex);
                }
                a.RemoveAt(lastItemIndex);
                if (b[val].Count == 0)
                {
                    b.Remove(val);
                }
                return true;
            }

            public int GetRandom()
            {
                Random r = new Random();
                int c = r.Next(0,a.Count);
                return a[c];
            }
        }