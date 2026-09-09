public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int>[] freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }
        Dictionary<int, int> vals = new Dictionary<int, int>();
        foreach(int i in nums) {
            if(!vals.ContainsKey(i)) {
                vals[i] = 1;
            } else {
                vals[i]++;
            }
        }
        foreach(var pair in vals) {
            freq[pair.Value].Add(pair.Key);
        }
        int[] res = new int[k];
        int count = 0;
        for(int i = freq.Length - 1; i >= 0; i--) {
            foreach(int j in freq[i]) {
                res[count] = j;
                count++;
                if(count >= k) {
                    return res;
                }
            }
        }
        return res;
    }
}
