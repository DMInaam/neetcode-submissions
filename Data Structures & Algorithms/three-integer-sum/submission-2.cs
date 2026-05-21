public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        int n = nums.Length;
        Array.Sort(nums);
        for(int i=0;i<n-2;i++){
            if(nums[i]>0) break;
            if(i>0 && nums[i] == nums[i-1]) continue;
            int l = i+1;
            int r = n-1;
            while(l<r){
                int total = nums[i] + nums[l] + nums[r];
                if(total == 0){
                    result.Add(new List<int>{nums[i],nums[l],nums[r]});
                    l++;
                    r--;
                    while(l<r && nums[l] == nums[l-1]) l++;
                    while(l<r && nums[r] == nums[r+1]) r--;
                }
                else if(total>0) r--;
                else l++;
            }
        }
        return result; 
    }
}
