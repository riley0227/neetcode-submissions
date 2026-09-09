class MinStack {
private:
stack<int> mainStack;
stack<int> minStack;
public:
    MinStack() {
        
    }
    
    void push(int val) {
        if(minStack.empty() || val < minStack.top()) {
            minStack.push(val);
        } else {
            minStack.push(minStack.top());
        }
        mainStack.push(val);
    }
    
    void pop() {
        minStack.pop();
        mainStack.pop();
    }
    
    int top() {
        int theTop = mainStack.top();
        return theTop;
    }
    
    int getMin() {
        return minStack.top();
    }
};
