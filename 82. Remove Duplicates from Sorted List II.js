// Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.

// The number of nodes in the list is in the range [0, 300].
// -100 <= Node.val <= 100
// The list is guaranteed to be sorted in ascending order.
var { ListNode, buildListNode } = require('./utils');
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var deleteDuplicates = function(head) {
    if(head == null || head.next == null) { return head; }
    var dummy = new ListNode(0,head);
    var slow = dummy, fast = head;
    while(fast && fast.next) {
        if(fast.next != null && fast.val == fast.next.val){
            while(fast.next != null && fast.val == fast.next.val){
                fast = fast.next;
            }
            slow.next = fast.next;
        }else{
            slow = fast;
        }
        fast = fast.next
    }
    return dummy.next;
};

console.log(deleteDuplicates(buildListNode([1,1,2])).toArray());    // [2]
console.log(deleteDuplicates(buildListNode([1,2,3,3,4,4,5])).toArray());    // [1,2,5]
console.log(deleteDuplicates(buildListNode([0,0,0,0,0,0,0,0])));    // []
console.log(deleteDuplicates(buildListNode([1])).toArray());    // [1]
console.log(deleteDuplicates(buildListNode([])));    // []
console.log(deleteDuplicates(buildListNode([1,1,2,3,3])).toArray());// [2]
console.log(deleteDuplicates(buildListNode([1,1,1,2,3])).toArray());// [2,3]
console.log(deleteDuplicates(buildListNode([1,2,3,4,4])).toArray());// [1,2,3]
console.log(deleteDuplicates(buildListNode([1,1,2])).toArray());    // [2]