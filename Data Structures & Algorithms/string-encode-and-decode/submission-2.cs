public class Solution {

    public string Encode(List<string> strs) {
        string res = "";
        foreach(string s in strs) {
            res += s.Length + "#" + s;
        }
        return res;
    }

    public List<string> Decode(string s) {
        int i = 0;
        List<string> res = new List<string>();

        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int lengthOfWord = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            res.Add(s.Substring(i, lengthOfWord));
            i += lengthOfWord;
        }
        return res;
   }
}
