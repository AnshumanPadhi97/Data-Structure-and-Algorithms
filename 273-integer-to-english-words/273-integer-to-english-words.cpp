#include<bits/stdc++.h>
using namespace std;

#define ll long long
typedef unsigned long long ull;
typedef long double lld;
#define all(v) v.begin(), v.end()
#define revall(v) v.rbegin(), v.rend()
#define setbits __builtin_popcountll
#define nline "\n"
#define MOD1 (int)998244353
#define INF64 (ll)1e18
#define INF32 (int)1e9+7
#define yes cout<<"YES"
#define no cout<<"NO"

string digits[20] = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
string tens[10] = {"Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

class Solution {
public:
    string convert(int n){
        if(n>=1000000000){
            return convert(n/1000000000)+" Billion"+convert(n%1000000000);
        }
        else if(n>=1000000){
            return convert(n/1000000)+ " Million"+convert(n%1000000);
        }
        else if(n>=1000){
            return convert(n/1000)+" Thousand"+convert(n%1000);
        }
        else if(n>=100){
            return convert(n/100)+" Hundred"+convert(n%100);
        }
        else if(n>=20){
            return " "+tens[n/10]+convert(n%10);
        }
        else if(n>=1){
            return " "+digits[n];
        }
        else {
            return "";
        }
    }
    string numberToWords(int n) {
        if(n==0)return "Zero";
        else return convert(n).substr(1);
    }
};