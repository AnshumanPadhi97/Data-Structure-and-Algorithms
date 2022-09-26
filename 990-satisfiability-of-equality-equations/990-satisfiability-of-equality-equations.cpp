class Solution {
public:
    int uf[26];
    bool equationsPossible(vector<string>& equations) {
        int n = equations.size();
        for(int i=0;i<26;i++){
            uf[i]=i;
        }
        for(auto e:equations){
            if(e[1]=='='){
                int x = uf[e[0]-'a'];
                int y = uf[e[3]-'a'];
                x=find(x);
                y=find(y);
                uf[x] = y;
            }
        }
        for(auto e:equations){
            if(e[1]=='!'){
                int x = uf[e[0]-'a'];
                int y = uf[e[3]-'a'];
                x=find(x);
                y=find(y);
                if(x==y){//both == equation and != equation present in same group
                    return false;
                }
            }
        }
        return true;
    }
    int find(int x){
        if(x!=uf[x]){
            return uf[x] = find(uf[x]);
        }
        return uf[x];
    }
};