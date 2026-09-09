public class Solution {

    public string Encode(List<string> strs) {
        string res = "";
        foreach(string i in strs) {
            res += i.Length + "#" + i;
        }
        return res;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        while(i < s.Length) {
            int j = i;
            while(s[j] != '#') {
                j++;
            }
            int wordLength = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            res.Add(s.Substring(i, wordLength));
            i += wordLength;
        }
        return res;
   }
}
