public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> valuesOfNums = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if(valuesOfNums.ContainsKey(diff))
            {
                return new int[]{valuesOfNums[diff], i};
            }
            valuesOfNums[nums[i]] = i;
        }
        return new int[]{};
    }
}
