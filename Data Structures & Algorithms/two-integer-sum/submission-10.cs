public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> vals = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if(vals.ContainsKey(diff)) {
                return new int[] {vals[diff], i};
            } else {
                vals[nums[i]] = i;
            }
        }
        return new int[] {-1, -1};
    }
}
