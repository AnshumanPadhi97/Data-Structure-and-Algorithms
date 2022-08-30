class Solution {
public:
    string decodeString(string s) {
        stack<string> chars;
        stack<int> nums;
        string res;
        int num=0;
        for (auto &&c : s)
        {
            if(isdigit(c)){
                num = num*10+(c-'0');//build the number
            }
            else if(isalpha(c)){
                res.push_back(c);//build the string
            }
            else if(c=='['){
                //we can push all number and encoded_string to their stacks
                nums.push(num);
                chars.push(res);
                
                res="";//reset for another string building
                num=0;
            }
            else if(c==']'){
                // every time we see ']' we are guaranteed to have finished a set of 
                // k[encoded_string]. Hence we can start processing the stacks emptying
                // them and moving it to res. 
                string temp = res;
                for (int i = 0; i < nums.top()-1; i++)
                {
                    res+=temp;//repeat
                }
                res=chars.top()+res;//get previous decoded string from stack and put in front
                chars.pop();
                nums.pop();
            }
        }
        return res;
    }
    /*
    3[a]2[bc] --> aaabcbc
    (case 1) num = 3
    (case 3) push 3 to stack nums, nums = 0
    (case 2) res = a
    (case 4) res = aaa (Note chars.top() is empty)
    --------- we finished 3[a]
    Do again:
    (case 1) num = 2
    (case 3) push 3 to stack nums, push "aaa" to stack char, nums =0, res = ""
    (case 2) res = b
    (case 2) res = bc
    (case 4) res += tmp --> res = bcbc 
            res = chars.top() + res --> res = aaabcbcbc
     */

    /*
    What about an example where it is nested. 
     3[a2[bc]] = 3[abcbc] = abcbcabcbcabcbc
     (case 1) num = 3
     (case 3) push 3 to stack nums (nothing is added to chars)
     (case 2) res = a
     (case 1) num = 2
     (case 3) push 2 to stack nums, push a to stack chars
     so stack nums = top {2, 3} bottom  and stack chars = {"a"}, res = "", nums = 0
     (case 2) res = b
     (case 2) res = bc
     (case 4) time to empty the stacks and move to the final result!
            res = bcbc since nums.top() = 2 
            res = chars.top() + res --> res = abcbc since a is at the top of stack chars
            pop off from char and pop off from num
            chars = {} num = {3}
     (case 4) repeat for the last ']'
            res = abcbcabcbcabcbc
            res = chars.top() + res --> chars.top is empty so res = abcbcabcbcabcbc
        Done!    
*/
};