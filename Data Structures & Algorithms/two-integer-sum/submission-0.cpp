class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> theNums;
        vector<int> result;
        for(int i = 0; i < nums.size(); i++) {
            int remainingNum = target - nums[i];
            if(theNums.find(remainingNum) != theNums.end()) {
                if(theNums[remainingNum] < i) {
                    result.push_back(theNums[remainingNum]);
                    result.push_back(i);
                } else {
                    result.push_back(i);
                    result.push_back(theNums[remainingNum]);
                }
                return result;
            }
            theNums[nums[i]] = i;
        }
        return result;
    }
};
