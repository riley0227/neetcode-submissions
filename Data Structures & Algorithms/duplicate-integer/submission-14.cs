public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> vals = new HashSet<int>();
        foreach(int i in nums) {
            if(vals.Contains(i)) {
                return true;
            } else {
                vals.Add(i);
            }
        }
        return false;
    }
}
