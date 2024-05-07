using static LeetCodeSolutions.ConsoleApp.Problems.LinkedListDeleteNode;

namespace LeetCodeSolutions.ConsoleApp.Problems;

public class DoubleNumberLinkedList
{
    public static void Run(){
        // var head = new ListNode(9, new ListNode(9, new ListNode(9)));
        var head = new ListNode(1, new ListNode(8, new ListNode(9)));

        var result = DoubleIt(head);

        var expected = new ListNode(3, new ListNode(7, new ListNode(8)));
        // var expected = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(8))));

        var success = true;

        for (int i = 0; i < 3; i++){
            if (result.val == expected.val)
            {
                result = result.next;
                expected = expected.next;   
            }
            else {
                success = false;
            }
        }

        Console.WriteLine("Double Number In Linked List Success: " + success);
    }

    public static ListNode DoubleIt(ListNode head){
        if (head.val > 4){
            head = new ListNode(0, head);
        }

        var node = head;
        do{
            node.val = (node.val * 2) % 10;

            if (node.next != null && node.next.val > 4)
                node.val++;

            node = node.next;
        } while (node != null);

        return head;
    }


    /// FIRST ATTEMPT
    // private static ListNode DoubleIt(ListNode head, bool isRealHead = true){
    //     if (head.next == null)
    //     {
    //         head.val *= 2;
    //     }
    //     else {
    //         DoubleIt(head.next, false);

    //         head.val *= 2;

    //         while (head.next.val >= 10)
    //         {
    //             head.val++;
    //             head.next.val -= 10;
    //         }
    //     }

    //     if (isRealHead && head.val >= 10){
    //         var tempVal = head.val;
    //         head.val %= 10;
    //         tempVal = (tempVal - head.val) / 10;
    //         var realHead = new ListNode(tempVal, head);
    //         return realHead;
    //     }

    //     return head;
    // }
}
