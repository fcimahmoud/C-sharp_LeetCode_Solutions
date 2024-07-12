public class Solution {
    public int[] PlusOne(int[] digits) {
        int len = digits.Length;
        int[] result = new int[len + 1];

        int plusOne = 1;
        for (int i = len - 1; i >= 0; i--)
        {
            if (digits[i] == 9  && plusOne == 1)
                result[i + 1] = 0;
            else
            {
                result[i + 1] = digits[i] + plusOne;
                plusOne = 0;
            }
        }

        if (plusOne == 1) result[0] += 1;

        if (result[0] == 0)
        {
            int[] ans = new int[len];
            for (int i = 1; i < result.Length; i++)
                ans[i - 1] = result[i];
            return ans;
        }
        return result;
    }
}