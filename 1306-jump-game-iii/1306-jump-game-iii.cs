public class Solution {
    public bool CanReach(int[] arr, int start) {
            if (start < 0 || start >= arr.Length || arr[start] < 0) return false;
            arr[start] *= -1;
            return arr[start] == 0 || CanReach(arr, start + arr[start]) || CanReach(arr, start - arr[start]);
    }
}