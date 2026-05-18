public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;
        foreach(int i in set){
            if(!set.Contains(i-1)){
                int current = i;
                int length = 1;
                while(set.Contains(current+1)){
                    current++;
                    length++;
                }
                longest = Math.Max(longest,length);
            }
        }
        return longest;
    }
}
