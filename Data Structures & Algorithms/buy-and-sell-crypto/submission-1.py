class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        minP = float('inf')
        profit = 0
        for price in prices:
            minP = min(minP,price)
            profit = max(profit,price-minP)
        return profit