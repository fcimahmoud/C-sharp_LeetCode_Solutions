public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        Console.WriteLine(s);
        if (s.Length == 0) return 0;

        string res = "";

        if (s[0] == '-') 
        {
            res += '-';
            bool leadingZero = true;
            for (int i = 1; i < s.Length && res.Length <= 11; i++)
            {
                if (s[i] != '0')
                    leadingZero = false;
                if (char.IsDigit(s[i]) && !leadingZero)
                    res += s[i];
                else if (leadingZero)
                    continue;
                else break;
            }
        }
        else
        {
            if (s[0] == '+')
            {
                res += '+';
                bool leadingZero = true;
                for (int i = 1; i < s.Length && res.Length <= 11; i++)
                {
                    if (s[i] != '0')
                        leadingZero = false;
                    if (char.IsDigit(s[i]) && !leadingZero)
                        res += s[i];
                    else if (leadingZero)
                        continue;
                    else break;
                }
            }
            else
            {
                bool leadingZero = true;
                for (int i = 0; i < s.Length && res.Length <= 11; i++)
                {
                    if (s[i] != '0')
                        leadingZero = false;
                    if (char.IsDigit(s[i]) && !leadingZero)
                        res += s[i];
                    else if (leadingZero)
                        continue;
                    else break;
                }
            }
        }

        if (res.Length == 0 || (res.Length == 1 & res[0] == '-') || (res.Length == 1 & res[0] == '+')) return 0;

        if (Convert.ToInt64(res) < int.MinValue) return int.MinValue;
        else if (Convert.ToInt64(res) > int.MaxValue) return int.MaxValue;

        return Convert.ToInt32(res);
    }
}