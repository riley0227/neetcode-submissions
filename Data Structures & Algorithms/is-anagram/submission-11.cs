public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> valuesS = new Dictionary<char, int>();
        Dictionary<char, int> valuesT = new Dictionary<char, int>();
        if(s.Length != t.Length) {
            return false;
        }
        for(int i = 0; i < s.Length; i++) {
            valuesS[s[i]] = valuesS.GetValueOrDefault(s[i], 0) + 1;
            valuesT[t[i]] = valuesT.GetValueOrDefault(t[i], 0) + 1;
        }
        return  !valuesS.Except(valuesT).Any();
    }
}
