public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numsCount = new Dictionary<int, int>();
        var result = new List<int>[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            if(!numsCount.ContainsKey(nums[i]))
            {
                numsCount[nums[i]] = 0;
            }
            numsCount[nums[i]]++;
        }
        for(int i = 0; i < result.Length; i++)
        {
            result[i] = new List<int>();
        }

        foreach(var pair in numsCount)
        {
            result[pair.Value - 1].Add(pair.Key);
        }

        var kElements = new int[k];
        var count = 0;
        for(int i = result.Length - 1; i >= 0; i--)
        {
            foreach(var e in result[i])
            {
                kElements[count] = e;
                count++;
                if(count == k)
                {
                    return kElements;
                }
            }
        }
        return kElements;
    }
}
