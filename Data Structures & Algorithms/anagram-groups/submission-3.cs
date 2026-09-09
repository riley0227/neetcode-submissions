public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> together = new Dictionary<string, List<string>>();
        foreach(string s in strs) {
            int[] alph = new int[26];
            foreach(char c in s) {
                alph[c - 'a']++;
            }
            string key = string.Join(',', alph);
            if(!together.ContainsKey(key)) {
                together[key] = new List<string>();
            }
            together[key].Add(s);
        }
        return together.Values.ToList();
    }
}
