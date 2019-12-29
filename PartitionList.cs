 public class PartitionList
    {
        public static ListNode Partition(ListNode head, int x)
        {

            ListNode start = new ListNode(0);
            ListNode startHead = start;
            ListNode end = new ListNode(0);
            ListNode endHead = end;

            ListNode cur = head;

            while (cur != null)
            {

                if (cur.val < x)
                {
                    start.next = cur;
                    start = start.next;
                }
                else
                {
                    end.next = cur;
                    end = end.next;
                }

                cur = cur.next;
            }

            end.next = null;
            start.next = endHead.next;
            return startHead.next;


        }
    }
