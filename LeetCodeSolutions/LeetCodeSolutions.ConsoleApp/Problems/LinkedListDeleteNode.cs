namespace LeetCodeSolutions.ConsoleApp.Problems;

public class LinkedListDeleteNode
{

    public class ListNode{
        public int val;
        public ListNode? next;
        public ListNode(int x) { val = x; } 

        public ListNode(int val = 0, ListNode? next = null){
            this.val = val;
            this.next = next;
        }
    }

    public static void Run(){
        var list = new List<ListNode>(){
            { new ListNode(4) },
            { new ListNode(5) },
            { new ListNode(1) },
            { new ListNode(9) },
        };

        for (int i = 0; i < list.Count() - 1; i++){
            list[i].next = list[i + 1];
        }

        DeleteNode(list[1]);

        Console.WriteLine("Linked List Delete Node Success: " + !list.Any(x => x.val == 5));
    }

    private static void DeleteNode(ListNode node) {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
