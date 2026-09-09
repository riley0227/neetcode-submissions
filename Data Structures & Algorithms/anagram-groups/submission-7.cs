public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> wordGroups = new Dictionary<string, List<string>>();
        foreach(string s in strs) {
            int[] stringChars = new int[26];
            foreach(char c in s) {
                int charVal = c - 'a';
                stringChars[charVal]++;
            }
            string charsToString = string.Join(',', stringChars);
            if(!wordGroups.ContainsKey(charsToString)) {
                wordGroups[charsToString] = new List<string>();
            }
            wordGroups[charsToString].Add(s);
        }
        List<List<string>> result = new List<List<string>>(wordGroups.Values);
        return result;
    }
}
