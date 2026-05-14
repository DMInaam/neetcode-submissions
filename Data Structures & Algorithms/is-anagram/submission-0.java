class Solution {
    public boolean isAnagram(String s, String t) {
        int[] alp = new int[26];
        int st = s.length();
        int ts = t.length();
        if(st!=ts) return false;
        for(int i = 0;i<st;i++){
            alp[s.charAt(i)-'a']++;
            alp[t.charAt(i)-'a']--;
        }
        for(int i:alp)
            if (i != 0) 
                return false;
        return true;
    }
}
