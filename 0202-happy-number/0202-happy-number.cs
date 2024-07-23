public class Solution {
    public bool IsHappy(int n) {
        List<int> unHappy = new List<int>();
        while (n != 1)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                digit *= digit;
                sum += digit;
                n /= 10;
            }
            n = sum;
            if (unHappy.BinarySearch(n) >= 0)
                return false;
            unHappy.Add(n);
        }
        return true;
    }
}