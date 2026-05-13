public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
       int m = obstacleGrid.Length;
       int n = obstacleGrid[0].Length;
       int[] dp = new int[n];
       for(int i=m-1;i>=0;i--){
        for(int j=n-1;j>=0;j--){
            if(obstacleGrid[i][j] == 1) dp[j] = 0;
            else if(i == m-1 && j == n-1) dp[j] = 1;
            else if(j+1 < n) dp[j] += dp[j+1];
        }
       } 
       return dp[0];
    }
}