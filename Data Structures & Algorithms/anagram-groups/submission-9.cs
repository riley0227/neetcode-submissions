public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> worksInGroup = new Dictionary<string, List<string>>();
        foreach(string s in strs) {
            int[] theChars = new int[26];
            foreach(char c in s) {
                int i = c - 'a';
                theChars[i]++;
            }
            string word = string.Join(',', theChars);
            if(!worksInGroup.ContainsKey(word)) {
                worksInGroup[word] = new List<string>();
            }
            worksInGroup[word].Add(s);
            
        }
        return worksInGroup.Values.ToList();
    }
}
