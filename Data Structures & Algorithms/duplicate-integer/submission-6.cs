public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> through = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(through.Contains(nums[i])) {
                return true;
            }
            through.Add(nums[i]);
        }
        return false;
    }
}
