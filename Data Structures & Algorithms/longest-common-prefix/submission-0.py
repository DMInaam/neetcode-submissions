class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        s = strs[0]
        for i in range(1,len(strs)):
            j = 0
            while j<len(s) and j<len(strs[i]) and s[j] == strs[i][j]:
                j += 1
            s = s[:j]
            if not s:
                return ""
        return s
        