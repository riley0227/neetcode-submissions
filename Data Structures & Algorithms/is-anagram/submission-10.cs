public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> charsAndAmount = new Dictionary<char, int>();
        if(s.Length != t.Length) {
            return false;
        }
        for(int i = 0; i < s.Length; i++) {
            charsAndAmount[s[i]] = charsAndAmount.GetValueOrDefault(s[i], 0) + 1;
            charsAndAmount[t[i]] = charsAndAmount.GetValueOrDefault(t[i], 0) - 1;
        }
        foreach(int i in charsAndAmount.Values) {
            if(i != 0) {
                return false;
            }
        }
        return true;
    }
}
