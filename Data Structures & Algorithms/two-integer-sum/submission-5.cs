public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> values = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if(values.ContainsKey(diff)) {
                return new int[] {values[diff], i};
            } else {
                values[nums[i]] = i;
            }
        }
        return new int[] {-1, -1};
    }
}
