class Solution {
public:
    int uniqueMorseRepresentations(vector<string>& wo) {
        vector<string> d = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
        unordered_set<string> s;
        for (auto w : wo) {
            string code;
            for (auto c : w) code += d[c - 'a'];
            s.insert(code);
        }
        return s.size();
    }
};