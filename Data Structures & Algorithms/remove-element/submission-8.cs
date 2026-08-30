public class Solution {
    public int RemoveElement(int[] nums, int val) {        
        if (nums.Length == 1 && nums[0] == val) {
            nums[0] = 0; 
            return 0;
        } else if (nums.Length == 1 && nums[0] != val) {
            return 1;
        } else if (nums.Length == 0) {
            return 0;
        }
        int j = nums.Length - 1;
        int count = 0;
        while (j != 0 && nums[j] == val) {
            j--;
        } 

        if (j == 0) {
            int x = 0;
            while (x == nums.Length -1) {
                nums[x] = 0;
                x++;
            }
            return count;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == val) {
                if (i > j) {
                    continue;
                }
                while (nums[j] == val){
                    j--;
                }
                int temp = nums[j];
                nums[i] = temp;
                j--;
            } else {
                count++;
            }
        }
        return count;
    }
}