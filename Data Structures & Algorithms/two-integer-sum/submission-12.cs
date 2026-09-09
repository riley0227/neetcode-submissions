public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> vals = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int other = target - nums[i];
            if(vals.ContainsKey(other)) {
                return new int[]{vals[other], i};
            } else {
                vals[nums[i]] = i;
            }
        }
        return new int[]{};
    }
}
