public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
        foreach(string s in strs) {
            int[] charsInWord = new int[26];
            foreach(char c in s) {
                charsInWord[c - 'a']++;
            }
            string theChars = string.Join(',', charsInWord);
            if(!words.ContainsKey(theChars)) {
                words[theChars] = new List<string>();
            }
            words[theChars].Add(s);
        }
        return words.Values.ToList();
    }
}
