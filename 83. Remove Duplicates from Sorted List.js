// Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

// The number of nodes in the list is in the range [0, 300].
// -100 <= Node.val <= 100
// The list is guaranteed to be sorted in ascending order.
var { ListNode, buildListNode } = require('./utils');
/**
 * @param {ListNode} head
 * @return {ListNode}(
 */
var deleteDuplicates = function(head) {
    if(head != null && head.val != null){
        var slow = head, fast = head.next;
        while(fast) {
            if(slow.val!=fast.val){
                slow.next = fast;
                slow = slow.next;
            }
            fast = fast.next
        }
        slow.next = null;
    }
    return head;
};

console.log(deleteDuplicates(buildListNode([1,1,2])).toArray());    // [1,2]
console.log(deleteDuplicates(buildListNode([0,0,0,0,0,0,0,0])).toArray());    // [0]
console.log(deleteDuplicates(buildListNode([1])).toArray());    // [1]
console.log(deleteDuplicates(buildListNode([])));    // []
console.log(deleteDuplicates(buildListNode([1,1,2,3,3])).toArray());// [1,2,3]
console.log(deleteDuplicates(buildListNode([1,2,3,4,4])).toArray());// [1,2,3,4]
console.log(deleteDuplicates(buildListNode([1,1,2])).toArray());    // [1,2]