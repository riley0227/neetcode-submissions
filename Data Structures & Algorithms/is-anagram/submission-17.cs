public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> vals = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            if(!vals.ContainsKey(s[i])) {
                vals[s[i]] = 1;
            } else {
                vals[s[i]]++;
            }

            if(!vals.ContainsKey(t[i])) {
                vals[t[i]] = -1;
            } else {
                vals[t[i]]--;
            }

        }
        foreach(int i in vals.Values) {
            if(i != 0) {
                return false;
            }
        }
        return true;
        
    }
}
