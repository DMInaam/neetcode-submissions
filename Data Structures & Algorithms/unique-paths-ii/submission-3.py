class Solution:
    def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
        m,n = len(obstacleGrid), len(obstacleGrid[0])
        for i in range(m-1,-1,-1):
            for j in range(n-1,-1,-1):
                if obstacleGrid[i][j] == 1:
                    obstacleGrid[i][j] = 0
                elif i == m-1 and j == n-1:
                    obstacleGrid[i][j] = 1
                else:
                    right = obstacleGrid[i][j+1] if j+1 < n else 0
                    down = obstacleGrid[i+1][j] if i+1 < m else 0
                    obstacleGrid[i][j] = right + down
        return obstacleGrid[0][0]    