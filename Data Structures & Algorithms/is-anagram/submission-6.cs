public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        if(s.Length != t.Length) {
            return false;
        }
        
        for(int i = 0; i < s.Length; i++) {
            letters[s[i]] = letters.GetValueOrDefault(s[i], 0) + 1;
            letters[t[i]] = letters.GetValueOrDefault(t[i], 0) - 1;
        }

        foreach(int value in letters.Values) {
            if(value != 0) {
                return false;
            }
        }
        return true;
    }
}
