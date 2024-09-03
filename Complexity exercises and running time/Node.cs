using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity_exercises_and_running_time
{
    internal class Node
    {
        public int Value;
        public Node Next;

        public int GetValue()
        {
            return this.Value;
        }

        public void SetValue(int value)
        {
            this.Value = value;
        }

        public void SetNext(Node next)
        {
            this.Next = next;
        }

        public Node GetNext()
        {
            return this.Next;
        }

        public Node(int value)
        {
            this.Value = value;
        }
    }
}
