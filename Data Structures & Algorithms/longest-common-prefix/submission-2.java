class Solution {
    public String longestCommonPrefix(String[] strs) {
       StringBuilder s = new StringBuilder();
        s.append(strs[0]);
        for(int i = 1;i<strs.length;i++){
            int j = 0;
            while(j<s.length() && j<strs[i].length() && s.charAt(j) == strs[i].charAt(j))
                j++;
            s.setLength(j);
            if(s.length() == 0) return "";
        }
        return s.toString();
    }
}