using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            if (Head != null)
            {
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
            if (Head == null)
                return "";
            string values = "";
            Node current = Head;
            while (current != null)
            {
                values += current.Value + "-> ";
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
                return;
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
            while (Head.Value == data)
            {
                Head = Head.Next;
            }
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value == data)
                {
                    current.Next = current.Next.Next;
                }
                current = current.Next;
            }
        }

        // Method to remove the value in an index
        //public int RemoveIndex(int data)
        //{
        //    if (Head != null)
        //    {
        //        int count = 0;
        //        Node current = Head;
        //        while (current.Next != null)
        //        {
        //            if (count == data)
        //            {

        //            }
        //            count++;
        //        }
        //    }

        //    return -1;
        //}


        // O(n)
        // Method to find by value and return index
        public int Find(int data)
        {
            if (Head == null)
                return -1;
            int count = 0;
            Node current = Head;
            while (current.Next != null)
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
