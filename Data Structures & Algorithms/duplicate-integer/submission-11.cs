public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> values = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(values.Contains(nums[i])) {
                return true;
            }
            values.Add(nums[i]);
        }
        return false;
    }
}
