public class Solution {
    public int Candy(int[] ratings) {
       var candies = new int[ratings.Length];
        candies[0] = 1;		
        for(int i = 1; i < ratings.Length; i++)
            if(ratings[i - 1] < ratings[i])
                candies[i] = candies[i-1] + 1;
            else
                candies[i] = 1;
				
        for(int i = ratings.Length - 2; i >= 0; i--)
           if(ratings[i] > ratings[i + 1])
               candies[i] = Math.Max(candies[i + 1] + 1, candies[i]);
              
        return candies.Sum();
    }
}