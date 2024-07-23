public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (Math.Log2(n) != (int)Math.Log2(n))
            return false;
        return true;
    }
}