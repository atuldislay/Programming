 public class RandomNodeLinkedList
    {
        private Node _head;

        public class Node
        {
            public readonly int Data;
            public Node Next;

            public Node(int d)
            {
                Data = d;
                Next = null;
            }
        }

        public void AddAtStart(int data)
        {
            Node node = new Node(data);
            if (_head == null)
            {
                _head = node;
                return;
            }

            node.Next = _head;
            _head = node;
        }

        public void PrintList()
        {
            if (_head == null)
            {
                return;
            }

            Node temp = _head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        public int GetRamdom()
        {

            int restult = _head.Data;
            Node current = _head;
            for (int n = 1; current != null; n++)
            {

                if (new Random().Next() % n == 0)
                {
                    restult = current.Data;
                }

                current = current.Next;
            }

            return restult;

        }
    }
