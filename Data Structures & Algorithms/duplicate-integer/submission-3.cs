public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        foreach(int i in nums){
            if(!seen.Add(i)) return true;
        }
        return false;
    }
}