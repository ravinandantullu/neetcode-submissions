public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        int j = 0;
        string value = string.Empty;
        while (i < word1.Length || j < word2.Length) {
            string word1Value = string.Empty;
            if (i < word1.Length) {
                word1Value = word1[i].ToString();
            }
            string word2Value = string.Empty;
            if (j < word2.Length) {
                word2Value = word2[i].ToString();
            }
            value = value + word1Value + word2Value;
            i++;
            j++;
        }

        return value;
    }
}