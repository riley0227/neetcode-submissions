public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> values = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach(int i in nums) {
            if(!values.ContainsKey(i)) {
                values[i] = 1;
            } else {
                values[i]++;
            }
        }

        foreach(var v in values) {
            freq[v.Value].Add(v.Key);
        }

        int currentAmount = 0;
        int[] res = new int[k];
        for(int i = freq.Length - 1; i > 0; i--) {
            foreach (int n in freq[i]) {
                res[currentAmount] = n;
                currentAmount++;
                if(currentAmount == k) {
                    return res;
                }
            }
        }
        return res;
    }
}
