public class Solution {

    public string Encode(List<string> strs) {
        string res = "";
       foreach(string s in strs) {
            res += s.Length + "#" + s;
       }
       return res;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        int j = 0;
        while(i < s.Length) {
            while(s[j] != '#') {
                j++;
            }
            int countWord = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            string word = s.Substring(i, countWord);
            res.Add(word);
            i += countWord;
            j = i;
        }
         return res;
   }
}
