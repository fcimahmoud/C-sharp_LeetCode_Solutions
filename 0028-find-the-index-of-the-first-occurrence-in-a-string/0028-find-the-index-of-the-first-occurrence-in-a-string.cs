public class Solution {
    public int StrStr(string haystack, string needle) {
        int needle_length = needle.Length;
        int haystack_length = haystack.Length;

        for (int i = 0; i <= haystack_length - needle_length; i++)
        {
            string subStack = haystack.Substring(i, needle_length);
            if (subStack == needle) return i;
        }
        return -1;
    }
}