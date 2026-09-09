public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> valsAndIndx = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if(valsAndIndx.ContainsKey(diff)) {
                return new int[] {valsAndIndx[diff], i};
            }
            valsAndIndx[nums[i]] = i;
        }
        return new int[] {-1, -1};
    }
}
