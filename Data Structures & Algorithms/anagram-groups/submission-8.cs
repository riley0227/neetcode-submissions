public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
        foreach(string s in strs) {
            int[] charsInString = new int[26];
            foreach(char c in s) {
                charsInString[c - 'a']++;
            }
            string stringNumsOfWords = string.Join(',', charsInString);
            if(!words.ContainsKey(stringNumsOfWords)) {
                words[stringNumsOfWords] = new List<string>();
                words[stringNumsOfWords].Add(s);
            } else {
                words[stringNumsOfWords].Add(s);
            }
            
        }
        return words.Values.ToList();
    }
}
