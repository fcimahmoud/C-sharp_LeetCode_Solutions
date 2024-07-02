public class Solution {
        public int RomanToInt(string s)
        {
            int len = s.Length, res = 0;

            for (int i = 0; i < len; i++)
            {
                int s1 = value(s[i]);
                if (i + 1 < len)
                {
                    int s2 = value(s[i + 1]);
                    if (s1 >= s2)
                        res += s1;
                    else
                    {
                        res += (s2 - s1);
                        i++;
                    }
                }
                else
                    res += s1;
            }
            return res;
        }

        public static int value (char c)
        {
            if (c == 'I')
                return 1;
            if (c == 'V')
                return 5;
            if (c == 'X')
                return 10;
            if (c == 'L')
                return 50;
            if (c == 'C')
                return 100;
            if (c == 'D')
                return 500;
            if (c == 'M')
                return 1000;

            return -1;
        }
}