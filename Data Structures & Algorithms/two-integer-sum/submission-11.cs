public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> valsIndex = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if(valsIndex.ContainsKey(diff)) {
                return new int[] {valsIndex[diff], i};
            } else {
                valsIndex[nums[i]] = i;
            }
        }
        return new int[] { -1, -1};
    }
}
