class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        unordered_set<int> presentNums;
        for(int i = 0; i < nums.size(); i++) {
            if(presentNums.find(nums[i]) != presentNums.end()) {
                return true;
            }
            presentNums.insert(nums[i]);
        }
        return false;
    }
};
