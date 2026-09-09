class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> numsPres;
        for(int i = 0; i < nums.size(); i++) {
            int comp = target - nums[i];
            if(numsPres.find(comp) != numsPres.end()) {
                return {numsPres[comp], i};
            }
            numsPres[nums[i]] = i;
        }
        return {};
    }
};
