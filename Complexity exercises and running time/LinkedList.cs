namespace Complexity_exercises_and_running_time
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList() { }

        // O(1)
        public LinkedList(int data)
        {
            if (Head == null)
            {
                Node newNode = new Node(data);
                Head = newNode;
            }
        }

        // O(n)
        // Method to add to  the end of the list
        public void Add(int data)
        {
            if (Head == null)
            {
                Node newNode = new Node(data);
                Head = newNode;
                return;
            }
            if (Head != null)
            {
                if (Head.Value == null)
                {
                    Head.Value = data;
                    return;
                }
                Node newNode = new Node(data);
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // O(n)
        public string Display()
        {
            Node current = Head;
            string values = "";
            if (current != null)
            {
                values += current.Value.ToString();
                current = current.Next;
            }
            while (current != null)
            {
                values += " -> " + current.Value;
                current = current.Next;
            }
            return values;
        }

        // O(n)
        public int Length()
        {
            if (Head == null)
                return 0;
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        // O(n)
        // Method to remove the first value
        public void RemoveValue(int data)
        {
            if (Head == null)
                return;
            if (Head.Value == data)
            {
                Head = Head.Next;
            }
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        // O(n)
        // Method to remove all the values from the list
        public void RemoveAllValues(int data)
        {
            if (Head == null)
                return;
            while (Head != null && Head.Value == data)
            {
                Head = Head.Next;
            }
            Node current = Head;
            while (current != null && current.Next != null)
            {
                if (current.Next.Value == data)
                {
                    current.Next = current.Next.Next;
                }
                current = current.Next;
            }
        }

        // Method to remove the value in an index
        public void RemoveIndex(int index)
        {
            if (index == 0)
            {
                if (Head != null)
                {
                    Head = Head.Next;
                }
                return;
            }
            if (Head == null || index < 0)
            {
                return;
            }
            Node temp = Head;
            Node prev = null;
            for (int i = 0; i < index && temp.Next != null; i++)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp != null && prev != null)
            {
                prev.Next = temp.Next;
            }
        }

        // O(n)
        // Method to find by value and return index
        public int Find(int data)
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                if (current.Value == data)
                    return count;
                count++;
                current = current.Next;
            }
            return -1;
        }

        // O(n)
        // Method to get a value by index and return the value
        public int Get(int index)
        {
            if (Head == null)
                return -1;
            int count = 0;
            Node current = Head;
            while (current.Next != null)
            {
                if (count == index)
                    return current.Value;
                count++;
                current = current.Next;
            }
            return -1;
        }
    }
}
