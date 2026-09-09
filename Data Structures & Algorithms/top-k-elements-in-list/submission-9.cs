public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numsCount = new Dictionary<int, int>();

        foreach(var n in nums)
        {
            if(!numsCount.ContainsKey(n))
            {
                numsCount[n] = 1;
            }
            numsCount[n]++;
        }

        return numsCount
        .OrderByDescending(nc => nc.Value)
        .Take(k)
        .Select(k => k.Key)
        .ToArray();
    }
}
