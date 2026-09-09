class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int, int> count;
        vector<vector<int>> freq(nums.size() + 1);
        for(int n : nums) {
            count[n]++;
        }
        for(auto& entry : count) {
            freq[entry.second].push_back(entry.first);
        }
        vector<int> answer;
        for(int i = freq.size() -1; i > 0; i--) {
            for(auto& n : freq[i]) {
                answer.push_back(n);
                if (answer.size() == k) {
                    return answer;
                }
            }
        }
    }
};
