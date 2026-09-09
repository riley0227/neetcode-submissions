class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int l = 0;
        int r = 1;
        int maxProf = 0;
        while(r < prices.size()) {
            int currProfit = prices[r] - prices[l];
            if(currProfit > maxProf) {
                maxProf = currProfit;
            }
            if(prices[r] < prices[l]) {
                l = r;
            } 
            r++;
        }
        return maxProf;
    }
};
