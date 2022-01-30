/**
 * Definition for a binary tree node.
 **/
function TreeNode(val, left, right) {
    this.val = (val===undefined ? 0 : val)
    this.left = (left===undefined ? null : left)
    this.right = (right===undefined ? null : right)
}
function ListNode(val, next) {
    this.val = (val===undefined ? 0 : val)
    this.next = (next===undefined ? null : next)
}
ListNode.prototype.toArray = function() {
    var result = [];
    var current = this;
    while(current){
        result.push(current.val);
        current = current.next;
    }
    return result;
}

function buildListNode(arr) {
    var dummy = new ListNode(1);
    var current = dummy;
    arr.forEach(element => {
        current.next=new ListNode(element);
        current=current.next;
    });
    return dummy.next;
}
module.exports = { TreeNode, ListNode, buildListNode };