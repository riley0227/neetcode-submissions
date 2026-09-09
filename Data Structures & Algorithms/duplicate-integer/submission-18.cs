public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> doneVals = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(doneVals.Contains(nums[i])) {
                return true;
            }
            doneVals.Add(nums[i]);
        }
        return false;
    }
}
