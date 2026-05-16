class Solution:

    def encode(self, strs: List[str]) -> str:
        result = []
        for s in strs:
            result.append(str(len(s))+'#'+s);
        return "".join(result);
    def decode(self, s: str) -> List[str]:
        n = len(s)
        i = 0
        arr = []
        while i<n:
            j = i
            while s[j] != '#':
                j += 1
            length = int(s[i:j])
            j+=1
            arr.append(s[j:j+length])
            i = j+length
        return arr
