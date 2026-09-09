public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) {
            int value = 1;
            for(int j = 0; j < nums.Length; j++) {
                if(j == i) {
                    continue;
                }
                
                value *= nums[j];

            }
            output[i] = value;
        }
        return output;
    }
}
