public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> stringS = new Dictionary<char, int>();
        Dictionary<char, int> stringT = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++) {
            if(!stringS.ContainsKey(s[i]))
            {
                stringS[s[i]] = 1;
            } else 
            {
                stringS[s[i]]++;
            }
            if(!stringT.ContainsKey(t[i]))
            {
                stringT[t[i]] = 1;
            } else
            {
                stringT[t[i]]++;
            }
        }

        return stringS.All(kvp => stringT.TryGetValue(kvp.Key, out int val) && val == kvp.Value);
    }
}
