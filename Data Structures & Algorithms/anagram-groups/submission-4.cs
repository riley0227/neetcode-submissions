public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> vals = new Dictionary<string, List<string>>();
        foreach(string s in strs) {
            int[] countChars = new int[26];
            foreach(char c in s) {
                countChars[c - 'a']++;
            }
            string key = string.Join(',', countChars);
            if(vals.ContainsKey(key)) {
                vals[key].Add(s);
            } else {
                vals[key] = new List<string>();
                vals[key].Add(s);
            }
        }
        return vals.Values.ToList();

    }
}
