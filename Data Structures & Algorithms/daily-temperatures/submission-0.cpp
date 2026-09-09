class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
        stack<pair<int, int>> theStack;
        vector<int> result(temperatures.size(), 0);
        for(int i = 0; i < temperatures.size(); i++) {
            if (theStack.empty()) {
                theStack.push(make_pair(i, temperatures[i]));
            }
            while(!theStack.empty() && temperatures[i] > theStack.top().second) {
                result[theStack.top().first] = i - theStack.top().first;
                theStack.pop();
            }
            theStack.push(make_pair(i, temperatures[i]));
        }
        return result;
    }
};
