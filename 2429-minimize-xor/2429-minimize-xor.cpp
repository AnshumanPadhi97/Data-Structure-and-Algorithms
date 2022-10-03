#define setbits __builtin_popcountll

class Solution {
public:
    bool isSetBit(int bit,int num){
        return ((1<<bit) & num)>0;
    }
    int minimizeXor(int num1, int num2) {
        int a=setbits(num2);
        int res=0;
        for (int i = 30; i >= 0; i--)
        {
            if(a==0)break;
            if(isSetBit(i,num1)){
                res^=(1<<i);
                a--;
            }
        }
        int bit=0;
        while (a>0)
        {
            while (isSetBit(bit,num1))
            {
                bit++;
            }
            res^=(1<<bit);
            bit++;
            a--;
        }
        return res;
    }
};