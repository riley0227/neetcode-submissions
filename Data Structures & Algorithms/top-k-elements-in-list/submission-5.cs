public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> vals = new Dictionary<int, int>(); // this is for getting value and frequency of it
        List<int>[] freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length; i++) {
                freq[i] = new List<int>();
        }

        foreach(int i in nums) {
            vals[i] = vals.GetValueOrDefault(i, 0) + 1;
        }
        foreach(var pair in vals) {
            freq[pair.Value].Add(pair.Key);
        }
        int count = 0;
        int[] res = new int[k];
        for(int i = freq.Length - 1; i > 0; i--) {
            foreach(int j in freq[i]) {
                res[count] = j;
                count++;
            }
            if(count == k) {
                return res;
            }
        }
        return res;
    }
}
