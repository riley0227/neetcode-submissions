class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        dictS = {}
        dictT = {}

        if len(s) != len(t):
            return False

        for i in range(len(s)):
            dictT[t[i]] = dictT.get(t[i], 0) + 1
            dictS[s[i]] = dictS.get(s[i], 0) + 1

        return dictS == dictT

            