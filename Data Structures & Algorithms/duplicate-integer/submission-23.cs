public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();
    
        foreach(var number in nums) {
            if(numbers.Contains(number))
            {
                return true;
            }
            numbers.Add(number);
        }
        return false;
    }
}