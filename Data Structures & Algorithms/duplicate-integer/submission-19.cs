public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> vals = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(vals.Contains(nums[i])) {
                return true;
            }
            vals.Add(nums[i]);
        }
        return false;
    }
}
