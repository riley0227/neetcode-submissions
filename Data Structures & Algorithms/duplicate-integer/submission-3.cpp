class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        unordered_set<int> stuff;
        for(int i = 0; i < nums.size(); i++) {
            if(stuff.find(nums[i]) != stuff.end()) {
                return true;
            }
            stuff.insert(nums[i]);
        }
        return false;
    }
};
