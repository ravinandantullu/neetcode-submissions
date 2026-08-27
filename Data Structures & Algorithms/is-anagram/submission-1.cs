public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<int, int> valuesS = new();
        Dictionary<int, int> valuesT = new();

        if (s.Length != t.Length) {
            return false;
        }

        for(int i = 0; i < s.Length; i++) {
            int storeI = s[i];
            int storeJ = t[i];
            if (!valuesS.TryAdd(storeI, 1)) {
                valuesS[storeI] = valuesS[storeI] + 1;
            }
            
            if (!valuesT.TryAdd(storeJ, 1)) {
                valuesT[storeJ] = valuesT[storeJ] + 1;
            }
        }

        foreach (var entry in valuesS)
        {
            if (!valuesT.ContainsKey(entry.Key) || entry.Value != valuesT[entry.Key]) {
                return false;
            }
        }
        return true;
    }
}

