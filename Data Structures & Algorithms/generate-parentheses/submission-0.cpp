class Solution {
private:
    void backtrack(int n, int openN, int closedN, string current, vector<string>& res) {
        if(openN == closedN && openN == n) {
            res.push_back(current);
            return;
        }
        if(closedN < openN) {
            backtrack(n, openN, closedN + 1, current + ")", res);
        }
        if(openN < n) {
            backtrack(n, openN + 1, closedN, current + "(", res);
        }

    }
public:
    vector<string> generateParenthesis(int n) {
        vector<string> res;
        backtrack(n, 0, 0, "", res);
        return res;
    }
};
