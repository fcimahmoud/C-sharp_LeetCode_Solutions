public class Solution {
    public int Reverse(int x) {
        char sign = '+';
        if (x < 0)
            sign = '-';

        string str = x.ToString(), res;
        if (sign == '+') 
            res = sign + reverseString(str.Substring(0));
        else
            res = sign + reverseString(str.Substring(1));

        long ans = Convert.ToInt64(res);
        if (ans > int.MaxValue || ans < int.MinValue)
            return 0;

        return (int)ans;
    }
    public static string reverseString (string str)
    {
        char[] stringArray = str.ToCharArray();
        Array.Reverse(stringArray);
        return new string(stringArray);

    }
}