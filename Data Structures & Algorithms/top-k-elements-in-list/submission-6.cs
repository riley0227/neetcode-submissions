public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int>[] freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }
        Dictionary<int, int> countNums = new Dictionary<int, int>();

        foreach(int i in nums) {
            countNums[i] = countNums.GetValueOrDefault(i, 0) + 1;
        }

        foreach(var pair in countNums) {
            freq[pair.Value].Add(pair.Key);
        }
        int count = 0;
        int[] res = new int[k];
        for(int i = freq.Length - 1; i > 0; i--) {
            foreach(int num in freq[i]) {
                res[count] = num;
                count++;
                if(count == k) {
                    return res;
                }
            }
        }
        return res;
    }
}
