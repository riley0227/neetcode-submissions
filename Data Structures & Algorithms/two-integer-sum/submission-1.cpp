class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> values;
        vector<int> results;
        for(int i = 0; i < nums.size(); i++) {
            if(values.find(target - nums[i]) != values.end()) {
                return {values[target - nums[i]], i};
            }
            values[nums[i]] = i;
        }
        return {};
    }
};
