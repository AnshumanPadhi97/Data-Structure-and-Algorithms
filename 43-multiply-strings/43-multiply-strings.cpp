class Solution {
public:
    string multiply(string num1, string num2) {
        int m = num1.size();
        int n = num2.size();
        if(m==0||n==0||num1=="0"||num2=="0"){
            return "0";
        }
        if(num1=="1"){
            return num2;
        }
        if(num2=="1"){
            return num1;
        }
        vector<int>res(m+n,0);
        for (int i = m-1; i >= 0; i--)
        {
            for (int j = n-1; j >= 0; j--)
            {
                int prod = (num1[i]-'0')*(num2[j]-'0');

                prod+=res[i+j+1];//add previous main
                res[i+j+1]=prod%10;//for trimming main
                res[i+j]+=prod/10;//for trimming carry
            }            
        }
        int k=0;
        string ans="";
        while (res[k]==0)
        {
            k++;
        }
        while (k<res.size())
        {
            ans+=to_string(res[k++]);
        }        
        return ans;
    }
};