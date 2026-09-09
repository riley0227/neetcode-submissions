public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numCounts = new Dictionary<int, int>();

        foreach(var n in nums)
        {
            if(!numCounts.ContainsKey(n))
            {
                numCounts[n] = 0;
            }
            numCounts[n]++;
        }

        return numCounts.OrderByDescending(n => n.Value)
        .Take(k)
        .Select(n => n.Key)
        .ToArray();
    }
}
