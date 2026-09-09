public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var compliment = target - nums[i];

            if(dict.ContainsKey(compliment))
            {
                return new int[]{dict[compliment], i};
            } else {
                dict.Add(nums[i], i);
            }
        }

        return [];
    }
}
