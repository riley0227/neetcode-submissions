public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();

        foreach(var num in nums)
        {
            if(numbers.Contains(num))
            {
                return true;
            }
            numbers.Add(num);
        }
        return false;
    }
}