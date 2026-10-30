class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        DictS = defaultdict(int)
        DictT = defaultdict(int)

        for i in range(len(s)):
            DictS[s[i]] += 1
            DictT[t[i]] += 1

        return DictS == DictT