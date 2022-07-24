public class FoodRatings {
        Dictionary<string, (int, string)> foodRating;
        Dictionary<string, SortedSet<(int, string)>> cousineRatingFood;
        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            foodRating = new Dictionary<string, (int, string)>();
            cousineRatingFood = new Dictionary<string, SortedSet<(int, string)>>();

            for (int i = 0; i < foods.Length; i++)
            {
                foodRating.Add(foods[i], (ratings[i], cuisines[i]));
                cousineRatingFood.TryAdd(cuisines[i], new SortedSet<(int, string)>(Comparer<(int, string)>.Create((a, b) => a.Item1 != b.Item1 ? a.Item1.CompareTo(b.Item1) : b.Item2.CompareTo(a.Item2))));
                cousineRatingFood[cuisines[i]].Add((ratings[i], foods[i]));
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            string cousine = foodRating[food].Item2;
            int oldRating = foodRating[food].Item1;
            foodRating[food] = (newRating, cousine);

            cousineRatingFood[cousine].Remove((oldRating, food));
            cousineRatingFood[cousine].Add((newRating, food));
        }

        public string HighestRated(string cuisine)
        {
            return cousineRatingFood[cuisine].Max.Item2;
        }
}