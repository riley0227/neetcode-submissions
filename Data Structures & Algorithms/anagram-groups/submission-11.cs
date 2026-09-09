public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var results = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            var countChars = new int[26];
            foreach(var c in s)
            {
                countChars[c - 'a']++;
            }
            var charString = string.Join(",", countChars);
            if(!results.ContainsKey(charString))
            {
                results[charString] = new List<string>();
            }
            results[charString].Add(s);    
        }
        return results.Values.ToList();
    }
}