public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int minLength = strs[0].Length;
        for (int i = 0; i < strs.Length; i++) {
            if (strs[i].Length < minLength) {
                minLength = strs[i].Length;
            }
        }
        string y = String.Empty;
        for (int j = 0; j < minLength; j++) {
            int count = 0;
            char value = strs[0][j];
            for (int x = 0; x < strs.Length; x++) {
                if (strs[x][j] == value) {
                    count++;
                } else {
                    return y;
                }
            }
            if (count == strs.Length) {
                y = y + value;
            }
        }
        return y;
    }
}