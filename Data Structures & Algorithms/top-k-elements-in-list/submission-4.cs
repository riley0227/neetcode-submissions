public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> elementCount = new Dictionary<int, int>(); //number, quantaty of num
        List<int>[] valuesInFreq = new List<int>[nums.Length + 1];
        for(int i = 0; i < valuesInFreq.Length; i++) {
            valuesInFreq[i] = new List<int>();
        }

        for(int i = 0; i < nums.Length; i++) {
            if(!elementCount.ContainsKey(nums[i])) {
                elementCount[nums[i]] = 1;
            } else {
                elementCount[nums[i]]++;
            }
        }
        foreach(var pair in elementCount) {
            valuesInFreq[pair.Value].Add(pair.Key);
        }
        int count = 0;
        int[] res = new int[k];
        for(int i = valuesInFreq.Length - 1; i > 0; i--) {
            foreach(int j in valuesInFreq[i]) {
                res[count] = j;
                count++;
                if(count == k) {
                    return res;
                }
            }
        }
        return res;
    }
}
