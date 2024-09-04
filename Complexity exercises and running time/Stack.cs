using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity_exercises_and_running_time
{
    internal class Stack
    {
        public Node Top { get; set; }
        public int count { get; set; }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (count == 0)
            {
                this.Top = newNode;
            }
            else
            {
                newNode.Next = this.Top;
                this.Top = newNode;
            }
            count++;
        }

        public int Pop()
        {
            if (count == 0)
                return -1;
            int value = this.Top.Value;
            this.Top = this.Top.Next;
            count--;
            return value;
        }

        public int Peek()
        {
            if (count == 0)
                return -1;
            return this.Top.Value;
        }

        public int GetCount()
        {
            return this.count;
        }
    }
}
