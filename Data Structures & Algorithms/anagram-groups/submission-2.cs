public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        foreach(string s in strs) {
            int[] charsInString = new int[26];
            foreach(char c in s) {
                charsInString[c - 'a']++;
            }
            string key = string.Join(",", charsInString);
            if(!result.ContainsKey(key)) {
                result[key] = new List<string>();
            }
            result[key].Add(s);
        }
        return result.Values.ToList<List<string>>();
    }
}
