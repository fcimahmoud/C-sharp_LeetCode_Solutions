public class Solution {
    public int AddDigits(int num)
    {
        while (CountDigits(num) > 1)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            num = sum;
        }
        return num;
    }

    public int CountDigits(int num)
    {
        if (num == 0) return 1;

        int count = 0;
        while (num > 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
}