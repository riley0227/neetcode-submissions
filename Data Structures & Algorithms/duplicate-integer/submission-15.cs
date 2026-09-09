public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> vals = new HashSet<int>();
        foreach(int v in nums) {
            if (vals.Contains(v)) {
                return true;
            } else {
                vals.Add(v);
            }
        }
         return false;
    }
}
