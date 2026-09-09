public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char, int> values = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            values[s[i]] = values.GetValueOrDefault(s[i], 0) + 1;
            values[t[i]] = values.GetValueOrDefault(t[i], 0) - 1;
        }
        foreach(int value in values.Values) {
            if(value != 0) {
                return false;
            }
        }
        return true;
    }
}
