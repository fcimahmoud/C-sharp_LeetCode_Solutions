public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res = "";
        int minLength = strs[0].Length, indexOfMinLength = 0;
        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < minLength)
            { indexOfMinLength = i; minLength = strs[i].Length; }
        }
        for (int i = 0; i < minLength; i++)
        {
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j][i] != strs[indexOfMinLength][i])
                    return res;
            }
            res += strs[indexOfMinLength][i];
        }

        return res;
    }
}