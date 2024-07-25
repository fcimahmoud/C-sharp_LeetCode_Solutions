public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length !=  t.Length) return false;

        char[] sArray = s.ToCharArray();
        Array.Sort(sArray);

        char[] tArray = t.ToCharArray();
        Array.Sort(tArray);

        for (int i = 0; i < sArray.Length; i++)
            if (sArray[i] != tArray[i])
                return false;

        return true;
    }
}