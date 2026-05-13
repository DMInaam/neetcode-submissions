class Solution {
    public int uniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.length;
        int n = obstacleGrid[0].length;
        for(int i= m-1; i>= 0; i--){
            for(int j = n-1; j>= 0; j--){
                if(obstacleGrid[i][j] == 1) obstacleGrid[i][j] = 0;
                else if(i == m-1 && j == n-1) obstacleGrid[i][j] =1;
                else{
                    int right = (j+1<n)?obstacleGrid[i][j+1]:0;
                    int down = (i+1<m)?obstacleGrid[i+1][j]:0;
                    obstacleGrid[i][j] = right + down;
                } 
            }
        }
        return obstacleGrid[0][0];
    }
}