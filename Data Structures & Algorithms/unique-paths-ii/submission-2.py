class Solution:
    def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
        m,n = len(obstacleGrid), len(obstacleGrid[0])
        dp = [0] * n
        for i in range(m-1,-1,-1):
            for j in range(n-1,-1,-1):
                if obstacleGrid[i][j] == 1:
                    dp[j] = 0
                elif i == m-1 and j == n-1:
                    dp[j] = 1
                else:
                    right = dp[j+1] if j+1 < n else 0
                    dp[j] += right
        return dp[0]    