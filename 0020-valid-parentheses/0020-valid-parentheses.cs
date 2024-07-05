public class Solution {
    public bool IsValid(string s) {
        string store = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '[' || s[i] == '{' || s[i] == '(')
                store += s[i];
            else
            {
                if (s[i] == ']' && store.Length > 0 && store[store.Length - 1] != '[')
                    return false;
                else if (s[i] == '}' && store.Length > 0 && store[store.Length - 1] != '{')
                    return false;
                else if (s[i] == ')' && store.Length > 0 && store[store.Length - 1] != '(')
                    return false;
                else if (store.Length == 0) return false;
                else store = store.Remove(store.Length - 1);
            }
        }

        if(store.Length > 0) return false;
        else return true;
    }
}