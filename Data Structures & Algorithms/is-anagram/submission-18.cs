public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> valsS = new Dictionary<char, int>();
        Dictionary<char, int> valsT = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            if(!valsS.ContainsKey(s[i])) {
                valsS[s[i]] = 1;
            } else {
                valsS[s[i]]++;
            }
            if(!valsT.ContainsKey(t[i])) {
                valsT[t[i]] = 1;
            } else {
                valsT[t[i]]++;
            }
        }
        return !valsS.Except(valsT).Any();
        
    }
}
