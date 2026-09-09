public class Solution {
    public bool hasDuplicate(int[] nums) {
        var n = new HashSet<int>();

        foreach(var i in nums)
        {
            if(n.Contains(i)) {
                return true;
            }
            n.Add(i);
        }

        return false;
    }
}