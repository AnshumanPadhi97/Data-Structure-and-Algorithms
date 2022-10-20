class Solution {
public:
    string intToRoman(int num) {
        map<int, string> mp;
        
        mp[1] = "I";
        mp[5] = "V";
        mp[10] = "X";
        mp[50] = "L";
        mp[100] = "C";
        mp[500] = "D";
        mp[1000] = "M";
        mp[9] = "IX";
        mp[90] = "XC";
        mp[900] = "CM";
        mp[4] = "IV";
        mp[40] = "XL";
        mp[400] = "CD";
        
        int arr[13] = {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        
        string s="";
        
        while(num!=0)
        {
            for(int i =0; i<18;i++)
            {
                if(num-arr[i]>=0){
                    s+= mp[arr[i]];
                    num = num-arr[i];
                    break;
                }
            }
        }
        return s;
        
    }
};