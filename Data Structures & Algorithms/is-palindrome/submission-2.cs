public class Solution {
    public bool IsPalindrome(string s) {
        int j = s.Length - 1;
        for (int i = 0; i < s.Length; i++) {
            if (i == j) return true; 
            if (i > j) {
                break;
            }
            while(i < j && !IsStrictAlphanumeric(s[i])) {
                i++;
            }
            
            while(i < j && !IsStrictAlphanumeric(s[j])) {
                j--;
            }

            if (char.ToLower(s[i]) != char.ToLower(s[j])) {
                return false;
            }
            j--;
        }
        return true;
    }

    public static bool IsStrictAlphanumeric(char c)
    {
        return (c >= 'a' && c <= 'z') || 
            (c >= 'A' && c <= 'Z') || 
            (c >= '0' && c <= '9');
    }
}
