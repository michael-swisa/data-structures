using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity_exercises_and_running_time
{
    internal class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Left { get; set; }

        public TreeNode(int value)
        {
            this.Value = value;
            this.Right = null;
            this.Left = null;
        }
    }
}
