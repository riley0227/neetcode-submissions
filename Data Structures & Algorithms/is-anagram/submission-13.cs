public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        Dictionary<int, int> strS = new Dictionary<int, int>(); //compare the3se dictionaryies to make sure same
        Dictionary<int, int> strT = new Dictionary<int, int>();

        for(int i = 0; i < s.Length; i++) {
            strS[s[i]] = strS.GetValueOrDefault(s[i], 0) + 1;
            strT[t[i]] = strT.GetValueOrDefault(t[i], 0) + 1;
        }
        return !strS.Except(strT).Any();
    }
}
