class Solution {
    private int dfs(int i,int j,int[][] grid,int m,int n){
        if(i>=m || j>= n || grid[i][j] == 1) return 0;
        if(i == m-1 && j == n-1) return 1;
        if(grid[i][j]<0) return (-grid[i][j])-1;
        int right = dfs(i,j+1,grid,m,n);
        int down = dfs(i+1,j,grid,m,n);
        int total = right + down;
        grid[i][j] = -(total+1);
        return total;
    }
    public int uniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.length;
        int n = obstacleGrid[0].length;
        if(obstacleGrid[0][0] == 1 || obstacleGrid[m-1][n-1] == 1 ) return 0;
        return dfs(0,0,obstacleGrid,m,n);
    }
}