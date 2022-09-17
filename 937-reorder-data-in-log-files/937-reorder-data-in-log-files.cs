public class Solution {
        public string[] ReorderLogFiles(string[] logs)
        {
            var d = new List<string>();
            var l = new List<string>();
            foreach (var item in logs)
            {
                if(char.IsDigit(item.Split(' ')[1][0])){
                    d.Add(item);
                }
                else
                {
                    l.Add(item);
                }
            }
            l.Sort(new comp());
            l.AddRange(d);
            return l.ToArray();
        }
        public class comp : IComparer<string>
        {
            public int Compare(string a,string b)
            {
                var l1 = a.Split(' ', 2);//identifier, content
                var l2 = b.Split(' ', 2);
                var c = l1[1].CompareTo(l2[1]);//compare contents
                if (c != 0) return c;
                else return l1[0].CompareTo(l2[0]);//if same content then compare identifier
            }
        }
}