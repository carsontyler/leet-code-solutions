using static LeetCodeSolutions.ConsoleApp.Problems.LinkedListDeleteNode;

namespace LeetCodeSolutions.ConsoleApp.Problems;

public class RemoveGreaterNodeLinkedList
{
    public static void Run(){
        var list = new List<ListNode>(){
            { new ListNode(5) },
            { new ListNode(2) },
            { new ListNode(13) },
            { new ListNode(3) },
            { new ListNode(8) },
        };

        for (int i = 0; i < list.Count() - 1; i++){
            list[i].next = list[i + 1];
        }

        var result = RemoveNodes(list.First());

        var expected = new List<ListNode>(){
            new ListNode(13),
            new ListNode(8)
        };

        var success = true;
        for (int i = 0; i < expected.Count; i++){
            if (expected[i].val != result.val){
                success = false;
                break;
            }
            else{
                result = result.next;
            }
        }

        Console.WriteLine("Remove Greater Node From Linked List Success: " + success);
    }

    private static ListNode RemoveNodes(ListNode head) {
        if (head == null || head.next == null)
            return head;

        var next = RemoveNodes(head.next);
        if (next.val > head.val)
            head = next;
        else
            head.next = next;

        return head;
    }
}
