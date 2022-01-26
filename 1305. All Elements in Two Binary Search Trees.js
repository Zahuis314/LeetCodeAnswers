// Given two binary search trees root1 and root2, return a list containing all the integers from both trees sorted in ascending order.

// The number of nodes in each tree is in the range [0, 5000].
// -10^5 <= Node.val <= 10^5
var {TreeNode} = require('./utils');

/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var inorder = function(root){
    if(root)
    {
        return [...inorder(root.left), root.val, ...inorder(root.right)];
    }
    return []
};
/**
 * @param {TreeNode} root1
 * @param {TreeNode} root2
 * @return {number[]}
 */
var getAllElements = function(root1, root2) {
    root1Inorder = inorder(root1);
    root2Inorder = inorder(root2);
    var i=0,j=0;
    result = [];
    while(i<root1Inorder.length && j<root2Inorder.length){
        if(root1Inorder[i]<root2Inorder[j]){
            result.push(root1Inorder[i++]);
        } else {
            result.push(root2Inorder[j++]);
        }
    }
    while(i<root1Inorder.length)
        result.push(root1Inorder[i++]);
    while(j<root2Inorder.length)
        result.push(root2Inorder[j++]);
    return result;
};
var tn_0_0_1 = new TreeNode(1);
var tn_0_0_4 = new TreeNode(4);
var tn_0_0_2 = new TreeNode(2,tn_0_0_1,tn_0_0_4);
var tn_0_1_0 = new TreeNode(0);
var tn_0_1_3 = new TreeNode(3);
var tn_0_1_1 = new TreeNode(1,tn_0_1_0,tn_0_1_3);
var result_0 = getAllElements(tn_0_0_2,tn_0_1_1);

var tn_1_0_8 = new TreeNode(8);
var tn_1_0_1 = new TreeNode(1,null,tn_1_0_8);
var tn_1_1_1 = new TreeNode(1);
var tn_1_1_8 = new TreeNode(8,tn_1_1_1);
var result_1 = getAllElements(tn_1_0_1,tn_1_1_8);
