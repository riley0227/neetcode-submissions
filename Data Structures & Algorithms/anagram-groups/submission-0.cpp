class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> answer;
        for(int i = 0; i < strs.size(); i++) {
            vector<int> countChars(26, 0);
            for(int j = 0; j < strs[i].size(); j++) {
                countChars[strs[i][j] - 'a']++;   
            }
            string key;
            for(int j = 0; j < countChars.size(); j++) {
                key += "#" + to_string(countChars[j]);
            }
            answer[key].push_back(strs[i]);
        }
        vector<vector<string>> result;
        for(auto& pair : answer) {
            result.push_back(pair.second);
        }
        return result;
    }
};
