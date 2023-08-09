/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var x = BuildReverseNumber(l1) + BuildReverseNumber(l2);
        var l = new ListNode();
        var current = l;
        string reversed = new string(x.ToString().Reverse().ToArray());
        for(int i = 0; i < reversed.Count(); i++){
            current.val = (int)Char.GetNumericValue(reversed[i]);
            if(reversed.Count() - i > 1){
                current.next = new ListNode();
                current = current.next;
            }
        }
        return l;
    }

    private int BuildReverseNumber(ListNode l){
        ListNode currentNode = l;
        Stack<int> numbers = new Stack<int>();
        numbers.Push(currentNode.val);
        while(currentNode.next != null){
            currentNode = currentNode.next;
            numbers.Push(currentNode.val);
        }
        int multiplier = 1;
        int finalNum = 0;
        while(numbers.Count > 0){
            int x = numbers.Pop();
            finalNum += (x * multiplier);
            multiplier *= 10;
        }
        return finalNum;
    }
}