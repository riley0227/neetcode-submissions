class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int l = 0; 
        int r = 1;
        int maxProf = 0;
        while(r < prices.size()) {
            int currProf = prices[r] - prices[l];
            if(currProf > maxProf) {
                maxProf = currProf;
            }
            if(prices[r] < prices[l]) {
                l = r;
            }
            r++;
        }
        return maxProf;
       
    }
};
