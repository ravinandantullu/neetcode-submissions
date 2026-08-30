public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> values = new();
        int max = 0;
        int number = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (values.TryGetValue(nums[i], out int sumV)) {
                values[nums[i]] = sumV + 1;
                if (max < (sumV + 1)) {
                    max = sumV + 1;
                    number = nums[i];
                }
            } else {
                values.Add(nums[i], 1);
                if (max == 0) {
                    max = 1;
                    number = nums[i];
                }
            }
        }
        return number;
    }
}