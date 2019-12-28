 class ConnectedComponent
    {
        public int NumComponents(ListNode head, int[] G)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in G)
            {
                set.Add(i);
            }
            int ans = 0;
            ListNode curr = head;

            while (curr != null)
            {
                if (set.Contains(curr.val)
                    && (curr.next == null || !set.Contains(curr.next.val)))
                {
                    ans++;
                }
                curr = curr.next;
            }
            return ans;
        }
    }
