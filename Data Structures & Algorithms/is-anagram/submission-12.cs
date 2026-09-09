public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> charsS = new Dictionary<char, int>();
        Dictionary<char, int> charsT = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            charsS[s[i]] = charsS.GetValueOrDefault(s[i], 0) + 1;
            charsT[t[i]] = charsT.GetValueOrDefault(t[i], 0) + 1;
        }

        return !charsS.Except(charsT).Any();
    }
}
