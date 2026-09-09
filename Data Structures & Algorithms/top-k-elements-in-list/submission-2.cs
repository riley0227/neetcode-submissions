public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> vals = new Dictionary<int, int>();// stores value then amount
        List<int>[] freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length; i++){
            freq[i] = new List<int>();
        }

        foreach(int i in nums) {
            if(vals.ContainsKey(i)) {
                vals[i]++;
            } else {
                vals[i] = 1;
            }
        }

        foreach(var val in vals) {
            freq[val.Value].Add(val.Key);
        }

        int count = 0;
        int[] res = new int[k];
        for(int i = freq.Length - 1; i > 0; i--) {
            foreach(int v in freq[i]) {
                res[count] = v;
                count++;
                if(count == k) {
                    return res;
                }
            }
        }
        return res;
    }
}
