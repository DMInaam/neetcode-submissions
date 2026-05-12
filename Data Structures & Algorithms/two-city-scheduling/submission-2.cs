public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        Array.Sort(costs,(a,b)=>{
            int diffA = a[0] - a[1];
            int diffB = b[0] - b[1];
            return diffA.CompareTo(diffB);
        });
        int n = costs.Length;
        int ans = 0;
        for(int i = 0;i<n;i++){
            if(i < n/2) ans+= costs[i][0];
            else ans += costs[i][1];
        }
        return ans;
    }
}