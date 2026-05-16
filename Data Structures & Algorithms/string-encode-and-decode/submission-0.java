class Solution {
    //LeetCode 271
    public String encode(List<String> strs) {
        StringBuilder s = new StringBuilder();
        for(String st:strs){
            s.append(st.length()).append('#').append(st);
        }
        return s.toString();
    }

    public List<String> decode(String str) {
        int n = str.length();
        int i = 0;
        List<String> arr = new ArrayList<>();
        while(i<n){
            int j = i;
            while(str.charAt(j) != '#') j++;
            int length = Integer.parseInt(str.substring(i,j));
            j++;
            arr.add(str.substring(j,j+length));
            i = j+length;
        }
        return arr;
    }
}
