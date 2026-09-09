class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int maxProfit = 0;
        int left = 0;
        int right = 1;
        while (right < prices.size()) {
            if (prices[left] > prices[right]) {
                if((prices[right] - prices[left]) > maxProfit) {
                    maxProfit = (prices[right] - prices[left]);
                }
                left = right;
                right++;
            } else {
                if((prices[right] - prices[left]) > maxProfit) {
                    maxProfit = (prices[right] - prices[left]);
                }
                right++;
            }
        }
        return maxProfit;
    }
};
