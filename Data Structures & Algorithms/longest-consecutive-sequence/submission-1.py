class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        uniq = set(nums)
        longest = 0
        for i in uniq:
            if i-1 not in uniq:
                current = i
                length = 1
                while current+1 in uniq:
                    current+=1
                    length+=1
                longest = max(longest,length);
        return longest 