public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> charsS = new Dictionary<char, int>();
        Dictionary<char, int> charsT = new Dictionary<char, int>();
        if(s.Length != t.Length) {
            return false;
        }
        for(int i = 0; i < s.Length; i++) {
            if(charsS.ContainsKey(s[i])) {
                charsS[s[i]]++;
            } else {
                charsS[s[i]] = 1;
            }

            if(charsT.ContainsKey(t[i])) {
                charsT[t[i]]++;
            } else {
                charsT[t[i]] = 1;
            }
        }
        return !charsS.Except(charsT).Any();
        
    }
}
