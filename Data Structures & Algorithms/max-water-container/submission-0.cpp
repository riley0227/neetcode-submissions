class Solution {
public:
    int maxArea(vector<int>& heights) {
        int l = 0;
        int r = heights.size() - 1;
        int maxArea = 0;
        while(l < r) {
            if (((r - l) * min(heights[l], heights[r])) > maxArea) {
                maxArea = (r - l) * min(heights[l], heights[r]);
            }
            if(heights[l] < heights[r]) {
                l++;
            } else {
                r--;
            }
        }
        return maxArea;
    }
};
