class Solution {
public:
    bool isValid(string s) {
       stack<char> open;
       unordered_map<char, char> parens {
        {'}', '{'},
        {')', '('},
        {']', '['},
       };

       for(int i = 0; i < s.size(); i++) {
        if(parens.find(s[i]) != parens.end()) {
            if(open.empty()) {
                return false;
            }
            if(open.top() != parens[s[i]]) {
                return false;
            }
            open.pop();
        } else {
            open.push(s[i]);
        }
       }
       return open.empty();
    }
};
