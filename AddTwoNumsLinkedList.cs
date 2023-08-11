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

 //problem with uint not being big enough. but honestly it feels good.
public class Solution {

    public ListNode AddTwoNumbers(ListNode l, ListNode l2) {

        var s = GetReversedString(l);
        var s2 = GetReversedString(l2);

        var sumStr = (Convert.ToUInt64(s) + Convert.ToUInt64(s2)).ToString();
        Console.WriteLine(sumStr);
        ListNode result = new ListNode();

        
        result.val = (int)Char.GetNumericValue(sumStr[sumStr.Length - 1]);
        sumStr = sumStr.Remove(sumStr.Length - 1, 1);
        //go through string backwards

        ListNode worker = result;
        for(int i = sumStr.Length-1; i >= 0; i--){
            //make new connection
            worker.next = new ListNode();
            worker = worker.next;
            worker.val = (int)Char.GetNumericValue(sumStr[i]);
        }

        return result;
    }
    

    private string GetReversedString(ListNode listNode){
        var worker = listNode;
        
        //use a stack
        var stack = new Stack<string>();
        while(worker.next != null){
            stack.Push(worker.val.ToString());
            worker = worker.next;
        }
        stack.Push(worker.val.ToString());
        string s = stack.Pop();
        while(stack.Count > 0){
            s += stack.Pop();
        }
        return s;
    }
}