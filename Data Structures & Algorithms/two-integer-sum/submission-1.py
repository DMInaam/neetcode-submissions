class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        ts = dict()
        for i,num in enumerate(nums):
            comp = target - num
            if comp in ts:
                return [ts[comp],i]
            ts[num] = i
        