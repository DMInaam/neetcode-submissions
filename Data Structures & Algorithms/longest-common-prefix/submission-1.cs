public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string s = strs[0];
        for(int i =1;i<strs.Length;i++){
            int j=0;
            while(j<s.Length && j<strs[i].Length && s[j] == strs[i][j])
                j++;
            s = s.Substring(0,j);
            if(s.Length == 0) return "";
        }
        return s;
    }
}