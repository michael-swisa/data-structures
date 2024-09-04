using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity_exercises_and_running_time
{
    internal class Queue
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (Tail != null)
            {
                this.Tail.Next = newNode;
                this.Tail = newNode;
            }
            else
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            this.Count++;
        }

        public int Dequeue()
        {
            if (Head == null)
                return -1;

            int value = Head.Value;
            this.Head = Head.Next;
            this.Count--;
            return value;
        }

        public int Peek()
        {
            if (Head == null)
                return -1;
            return this.Head.Value;
        }

        public int GetCount()
        {
            return this.Count;
        }
    }
}
