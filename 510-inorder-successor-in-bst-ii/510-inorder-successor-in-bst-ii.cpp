/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* left;
    Node* right;
    Node* parent;
};
*/

class Solution {
public:
    Node* inorderSuccessor(Node* node) {
        //lower in right subtree
        if(node->right){
            node=node->right;
            while(node->left) node = node->left;
            return node;
        }
        
        //in upper of tree
        while(node->parent && node==node->parent->right) node = node->parent;
        return node->parent;
    }
};