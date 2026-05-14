public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] freq = new int[26];
        foreach(char c in s){
            freq[c - 'a']++;
        }
        foreach(char c in t){
            freq[c-'a']--;
            if(freq[c-'a']<0) return false;
        }
        return true;
    }
}
