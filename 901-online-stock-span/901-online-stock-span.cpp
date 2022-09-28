class StockSpanner {
public:
    stack<pair<int,int>> st;
    int index;
    StockSpanner() {
        index=-1;
    }
    
    int next(int price) {
        index+=1;
        while (!st.empty() && st.top().second<=price)//decreasing stack upwards
        {
            st.pop();
        }
        if(st.empty()){
            st.push({index,price});
            return index+1;//itself is span
        }
        int res=st.top().first;
        st.push({index,price});
        return index-res;//span
    }
};