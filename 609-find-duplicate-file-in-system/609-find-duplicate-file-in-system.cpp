class Solution {
public:
    vector<vector<string>> findDuplicate(vector<string>& paths) {
        
        unordered_map<string,vector<string>> files;
        vector<vector<string>> res;
        
        for(auto path:paths)
        {
            int i=0,j;
            while(path[i]!=' ') i++;
            
            string dir = path.substr(0,i), file, content;
            
            while(i++<size(path))
            {
                j=i;
                while(path[i]!='(')i++;
                file=path.substr(j,i-j);
                
                j=i;
                while(path[i++]!=')');
                
                content=path.substr(j,i-j);
                files[content].push_back(dir+'/'+file);
            }
        }
        for(auto content:files){
            if(content.second.size()>1){//same content more files, so return result
                res.push_back(content.second);
            }
        }
        return res;
    }
};