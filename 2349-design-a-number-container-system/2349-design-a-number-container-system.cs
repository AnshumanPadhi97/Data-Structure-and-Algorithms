 public class NumberContainers
        {
            SortedDictionary<int, int> ls = new SortedDictionary<int, int>();
            public NumberContainers()
            {

            }

            public void Change(int index, int number)
            {
                if (ls.ContainsKey(index))
                {
                    ls[index] = number;
                }
                else
                {
                    ls.Add(index, number);
                }
            }

            public int Find(int number)
            {
                return ls.Where(x=>x.Value == number).Select(x=>x.Key).FirstOrDefault(-1);
            }
        }