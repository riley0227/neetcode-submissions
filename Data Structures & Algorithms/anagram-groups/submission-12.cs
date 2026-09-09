public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       var results = new Dictionary<string, List<string>>();

       foreach(var s in strs)
       {
        var countChars = new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            countChars[s[i] - 'a']++;
        }
        var charsOfWord = string.Join(',', countChars);

        if(!results.ContainsKey(charsOfWord))
        {
            results[charsOfWord] = new List<string>();
        }

        results[charsOfWord].Add(s);
       }

       return results.Values.ToList();
    }
}