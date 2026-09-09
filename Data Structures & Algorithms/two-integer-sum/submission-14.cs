public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> values = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int additionalValue = target - nums[i];
            if(values.ContainsKey(additionalValue))
            {
                return new int[]{values[additionalValue], i};
            }
            values[nums[i]] = i;
        }
        return new int[]{};
    }
}
