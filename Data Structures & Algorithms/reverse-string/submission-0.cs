public class Solution {
    public void ReverseString(char[] s) {
        int i = s.Length - 1;
        int j = 0;
        while(j < i) {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            i--;
            j++;
        }
    }
}