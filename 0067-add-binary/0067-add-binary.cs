public class Solution {
    public string AddBinary(string a, string b) {
                    string res = "";
            int reminder = 0;
            if(a.Length == b.Length)
            {
                for (int i = a.Length - 1, j = b.Length - 1; i >= 0 && j >= 0; i--,j--)
                {
                    if (reminder == 0)
                    {
                        if (a[i] != b[j]) res += "1";
                        else if (a[i] == '0' && b[j] == '0') res += "0";
                        else { res += "0"; reminder = 1; }
                        //Console.WriteLine($"{reminder} {res}");

                    }
                    else
                    {
                        if (a[i] != b[j] && reminder == 1) { res += "0"; reminder = 1; }
                        else if (a[i] == '0' && b[j] == '0') { res += "1"; reminder = 0; }
                        else { res += "1"; reminder = 1; }
                        //Console.WriteLine($"{reminder} {res}");

                    }
                }
            }
            else if (a.Length > b.Length)
            {
                for (int i = a.Length - 1, j = b.Length - 1; i >= 0; i--, j--)
                {
                    if (j >= 0 )
                    {
                        if (reminder == 0)
                        {
                            if (a[i] != b[j]) res += "1";
                            else if (a[i] == '0' && b[j] == '0') res += "0";
                            else { res += "0"; reminder = 1; }
                            //Console.WriteLine($"{reminder} {res}");

                        }
                        else
                        {
                            if (a[i] != b[j] && reminder == 1) { res += "0"; reminder = 1; }
                            else if (a[i] == '0' && b[j] == '0') { res += "1"; reminder = 0; }
                            else { res += "1"; reminder = 1; }
                            //Console.WriteLine($"{reminder} {res}");

                        }
                    }
                    else
                    {
                        if ((a[i] == '0' && reminder == 1) || (a[i] == '1' && reminder == 0)) { res += "1"; reminder = 0; }
                        else if (a[i] == '0' && reminder == 0) { res += "0"; reminder = 0; }
                        else { res += "0"; reminder = 1; }
                    }
                }

            }
            else
            {
                for (int i = a.Length - 1, j = b.Length - 1; j >= 0; i--, j--)
                {
                    if (i >= 0)
                    {
                        if (reminder == 0)
                        {
                            if (a[i] != b[j]) res += "1";
                            else if (a[i] == '0' && b[j] == '0') res += "0";
                            else { res += "0"; reminder = 1; }
                            //Console.WriteLine($"{reminder} {res}");

                        }
                        else
                        {
                            if (a[i] != b[j] && reminder == 1) { res += "0"; reminder = 1; }
                            else if (a[i] == '0' && b[j] == '0') { res += "1"; reminder = 0; }
                            else { res += "1"; reminder = 1; }
                            //Console.WriteLine($"{reminder} {res}");

                        }
                    }
                    else
                    {
                        if ((b[j] == '0' && reminder == 1) || (b[j] == '1' && reminder == 0)) { res += "1"; reminder = 0; }
                        else if (b[j] == '0' && reminder == 0) { res += "0"; reminder = 0; }
                        else { res += "0"; reminder = 1; }
                    }
                }

            }
            if (reminder ==  1) res += reminder.ToString();
            res = reverseString(res);
            //Console.WriteLine($"{reminder} {res}");
            return res;
    }
    public static string reverseString (string str)
    {
        char[] stringArray = str.ToCharArray();
        Array.Reverse(stringArray);
        return new string(stringArray);

    }
}