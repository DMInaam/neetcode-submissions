public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            char[] c = s.ToCharArray();
            Array.Sort(c);
            string key = new string(c);
            if(!map.ContainsKey(key))
                map[key] = new List<string>();
            map[key].Add(s);
        }
        return map.Values.ToList<List<string>>();
    }
}
