public class Solution {
    public char SlowestKey(int[] releaseTimes, string keysPressed) {
            var temp = releaseTimes[0];
            var c = keysPressed[0];

            for (int i = 1; i < releaseTimes.Length; i++)
            {
                var diff = releaseTimes[i] - releaseTimes[i - 1];
                if (diff > temp || (diff == temp && keysPressed[i] > c))
                {
                    temp = diff;
                    c = keysPressed[i];
                }
            }

            return c;
    }
}