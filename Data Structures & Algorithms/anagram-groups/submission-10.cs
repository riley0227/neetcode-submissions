public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            var count = new int[26];
            foreach(var c in s)
            {
                count[c - 'a']++;
            } 
            var countStr = string.Join(",", count);
            if(!results.ContainsKey(countStr))
            {
                results[countStr] = new List<string>();
            }
            results[countStr].Add(s);
        }
        return results.Values.ToList<List<string>>();
    }
}