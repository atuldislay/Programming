
    public class OddEvenLinkedList
    {
        private ListNode _head;

        public class ListNode
        {
            public readonly int val;
            public ListNode next;

            public ListNode(int d)
            {
                val = d;
                next = null;
            }
        }

        public void AddAtStart(int data)
        {
            ListNode node = new ListNode(data);
            if (_head == null)
            {
                _head = node;
                return;
            }

            node.next = _head;
            _head = node;
        }

        public void PrintList()
        {
            if (_head == null)
            {
                return;
            }

            ListNode temp = _head;
            while (temp != null)
            {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }
        }

       

        public ListNode RearrangeList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode odd = head;
            ListNode evenFirst = head.next;
            ListNode even = evenFirst;


            while (true)
            {
                if (odd == null || even == null || even.next == null)
                {

                    odd.next = evenFirst;
                    break;
                }

                odd.next = even.next;
                odd = even.next;

                if (odd.next == null)
                {
                    even.next = null;
                    odd.next = evenFirst;
                    break;
                }

                even.next = odd.next;
                even = odd.next;
            }

            return head;


         
        }
    }

