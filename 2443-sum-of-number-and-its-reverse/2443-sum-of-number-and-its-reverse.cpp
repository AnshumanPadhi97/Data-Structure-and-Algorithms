class Solution {
public:
    bool sumOfNumberAndReverse(int num) {
        for (int i = 0; i <= num; i += 1) {
            auto s = to_string(i);
            reverse(s.begin(), s.end());
            if (stoi(s) + i == num) return true;
        }
        return false;
    }
};