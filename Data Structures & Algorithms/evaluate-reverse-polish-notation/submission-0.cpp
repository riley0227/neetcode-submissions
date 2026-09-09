class Solution {
public:
    int evalRPN(vector<string>& tokens) {
        stack<int> valuestoCompute; 
        for(int i = 0; i < tokens.size(); i++) {
            if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/") {
                if(tokens[i] == "+") {
                    int val1 = valuestoCompute.top();
                    valuestoCompute.pop();
                    int val2 = valuestoCompute.top();
                    valuestoCompute.pop();
                    valuestoCompute.push(val1 + val2);
                }
                if(tokens[i] == "-") {
                    int val1 = valuestoCompute.top();
                    valuestoCompute.pop();
                    int val2 = valuestoCompute.top();
                    valuestoCompute.pop();
                    valuestoCompute.push(val2 - val1);  
                }
                if(tokens[i] == "*") {
                    int val1 = valuestoCompute.top();
                    valuestoCompute.pop();
                    int val2 = valuestoCompute.top();
                    valuestoCompute.pop();
                    valuestoCompute.push(val1 * val2); 
                }
                if(tokens[i] == "/") {
                    int val1 = valuestoCompute.top();
                    valuestoCompute.pop();
                    int val2 = valuestoCompute.top();
                    valuestoCompute.pop();
                    valuestoCompute.push(val2 / val1); 
                }
            } else {
                valuestoCompute.push(stoi(tokens[i]));
            }
        }
        return valuestoCompute.top();
    }
};
