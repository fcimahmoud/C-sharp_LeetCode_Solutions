public class Solution {
    public int ClimbStairs(int n) {
        if (n == 0 || n == 1) return 1;
        else if (n == 2 || n == 3) return n;
        else if (n == 4) return 5;
        else if (n == 5) return 8;
        else if (n == 6) return 13;
        
        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }
}