class Node{
    public:
        unordered_map<char,Node*> children;
        unordered_map<string,int> counter;//maintain every prefix visit count
        Node(){};
};

class AutocompleteSystem {
public:

    Node* root = new Node();
    string prefix;

    struct compare{
        bool operator()(pair<int,string>& l, pair<int,string>& r){
            return l.first<r.first || (l.first==r.first && l.second.compare(r.second)>0); 
        }
    };

    void add(string sentense,int time){
        Node* node = root;
        for(auto c:sentense){
            if(!node->children[c]){
                node->children[c]=new Node();
            }
            node = node->children[c];
            node->counter[sentense]+=time;
        }
    }

    AutocompleteSystem(vector<string>& sentences, vector<int>& times) {
        for (int i = 0; i < sentences.size(); i++)
        {
            add(sentences[i],times[i]);
        }
    }
    
    vector<string> input(char c) {
        if(c=='#'){
            add(prefix,1);
            prefix.clear();
            return {};
        }
        prefix+=c;
        
        Node* node= root;
        for(char c:prefix){
            if(!node->children[c]){
                return {};
            }
            node=node->children[c];
        }
        priority_queue<pair<int,string>,vector<pair<int,string>>,compare> q;
        for(auto p: node->counter){
            q.push({p.second,p.first});
        }
        vector<string> res;
        for(int i=0;i<3 && !q.empty();i++){
            res.push_back(q.top().second);
            q.pop();
        }
        return res;
    }
};