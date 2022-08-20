public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
            Array.Sort(houses);
            Array.Sort(heaters);

            var ls = new List<int>();
            for (int i = 0; i < houses.Length; i++)
            {
                ls.Add(int.MaxValue);
            }

            //dist to nearest rhs heater
            for (int i = 0, h = 0; i < houses.Length && h < heaters.Length;)
            {
                if (houses[i] <= heaters[h])
                {
                    ls[i] = heaters[h] - houses[i];
                    i++;
                }
                else
                {
                    h++;
                }
            }

            //dist to nearest lhs heater
            for (int i = houses.Length - 1, h = heaters.Length - 1; i >= 0 && h >= 0;)
            {
                if (houses[i] >= heaters[h])
                {
                    ls[i] = Math.Min(ls[i], houses[i] - heaters[h]);
                    i--;
                }
                else
                {
                    h--;
                }
            }

            return ls.Max();
    }
}