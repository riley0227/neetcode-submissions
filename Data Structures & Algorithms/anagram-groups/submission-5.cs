public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
        List<List<string>> res = new List<List<string>>();

        foreach(string s in strs) {
            int[] charsInS = new int[26];
            foreach(char c in s) {
                // 'a' would be at charsInS[0]
                charsInS[c - 'a']++;
            }
            string key = string.Join(',', charsInS);
            if(!anagrams.ContainsKey(key)) {
                anagrams[key] = new List<string>();
            }
            anagrams[key].Add(s);
        }

        res = anagrams.Values.ToList();
        return res;

    }
}
