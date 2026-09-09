public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> letters = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            letters[s[i]] = letters.GetValueOrDefault(s[i], 0) + 1;
            letters[t[i]] = letters.GetValueOrDefault(t[i], 0) - 1;
        }

        foreach(int values in letters.Values) {
            if (values != 0) {
                 return false;
            }
        }
        return true;
    }
}
