public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<string, int> values = new();
        int j = nums.Length - 1;
        for(int i = 0; j > i; i++, j--) {
            string storeI = nums[i].ToString();
            string storeJ = nums[j].ToString();
            if (!values.TryAdd(storeI, 1)) { 
                return true;
            }
            
            if (!values.TryAdd(storeJ, 1)) { 
                return true;
            }
        }
        return false;
    }
}