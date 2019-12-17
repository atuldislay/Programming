 public class RandomNodeLinkedList
    {
        public ListNode _head;

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

     


        public int[] NextLargerNode(ListNode head)
        {
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            ListNode cur = head;

            while (cur != null)
            {
                list.Add(cur.val);
                cur = cur.next;
            }

            int[] res = new int[list.Count];

            for (int i = 0; i < list.Count; ++i)
            {
                while (stack.Count > 0 && (list[stack.Peek()] < list[i]))
                {
                    res[stack.Pop()] = list[i];
                }
                stack.Push(i);
            }

            return res;
        }
    }
