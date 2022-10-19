/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    int widthOfBinaryTree(TreeNode* root) {
        int count=0,maxCount=0;
        queue<pair<TreeNode*,int>> q;
        q.push({root,0});
        q.push({NULL,0});
        
        while(q.size() > 1){
            pair<TreeNode*,int> node = q.front();
            q.pop();
            
            pair<TreeNode*,int> node1=node;
            while(node1.first != NULL){
                int idx = node1.second - node.second;
               if(node1.first->left != NULL)
                    q.push({node1.first->left, (long long)2*idx});
                if(node1.first->right !=NULL)
                    q.push({node1.first->right, (long long )2*idx+1});
                count = (long long )(node1.second - node.second);
                maxCount= max(maxCount, count+1);
                node1 = q.front();
                q.pop();
            }
            q.push({NULL,0});
        }
        return maxCount;
    }
};