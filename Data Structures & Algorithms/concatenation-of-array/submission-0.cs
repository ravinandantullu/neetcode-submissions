public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int length = nums.Length;
        for (int i = 0; i < length; i++) {
            nums = nums.Append(nums[i]).ToArray();
        }
        return nums;
    }
}