public class Solution {
    public bool IsAnagram(string s, string t) {
       
        if(s.Length != t.Length) 
        {
            return false;
        }
        Dictionary<char, int> sString = new Dictionary<char, int>();
        Dictionary<char, int> tString = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(sString.ContainsKey(s[i]) is not true)
            {
                sString[s[i]] = 0;
            }
            sString[s[i]] += 1;

            if(tString.ContainsKey(t[i]) is not true)
            {
                tString[t[i]] = 0;
            }
            tString[t[i]] += 1;
        }
        return !sString.Except(tString).Any();
    }
}
