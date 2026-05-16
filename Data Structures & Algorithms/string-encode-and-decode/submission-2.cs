public class Solution {
    // LeetCode 271
    public string Encode(IList<string> strs) {
        StringBuilder s = new StringBuilder();
        foreach(string st in strs){
            s.Append(st.Length).Append('#').Append(st);
        }
        return s.ToString();
    }

    public List<string> Decode(string s) {
        int n = s.Length;
        int i = 0;
        List<string> arr = new List<string>();
        while(i<n){
            int j = i;
            while(s[j] != '#') j++;
            int length = int.Parse(s.Substring(i,j-i));
            j++;
            arr.Add(s.Substring(j,length));
            i = j+length;
        }
        return arr;
   }
}
