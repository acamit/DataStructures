namespace LinkedList
{
    public class LinkedListOperations
    {
        // returns true if first list is present in the second list
        public bool findList(Node first, Node second)
        {
            Node ptr1 = first, ptr2 = second;
            if (first == null && second == null)
            {
                return true;
            }

            if (first == null || (first != null && second == null))
            {
                return false;
            }

            while (second != null)
            {
                ptr2 = second;

                while (ptr1 != null)
                {
                    if (ptr2 == null)
                    {
                        return false;
                    }

                    else if (ptr1.data == ptr2.data)
                    {
                        ptr1 = ptr1.next;
                        ptr2 = ptr2.next;
                    }
                    else
                    {
                        break;
                    }
                }

                if (ptr1 == null)
                {
                    return true;
                }

                // start sub list from scratch. 
                ptr1 = first;

                // go to the next node of second list
                second = second.next;
            }
            return false;
        }
    }
}
