public class Solution {
    public int ClimbStairs(int n) {
        int[] ints = new int[n+1];
        if (n > 0) ints[1] = 1;
        if (n > 1) ints[2] = 2;
        if (n > 2)
        {
            for (int i = 3; i <= n; i++)
                ints[i] = ints[i-1] + ints[i-2];
        }
        return ints[n];
    }
}