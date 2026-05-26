public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue;
        int profit = 0;
        foreach(int price in prices){
            min = Math.Min(min,price);
            profit = Math.Max(profit,price-min);
        }
        return profit;
    }
}