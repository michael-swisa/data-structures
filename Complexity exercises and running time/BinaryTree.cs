using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity_exercises_and_running_time
{
    internal class BinaryTree
    {
        private TreeNode root;

        public BinaryTree()
        {
            this.root = null;
        }

        public void Insert(int value)
        {
            TreeNode newNode = new TreeNode(value);
            if (root == null)
            {
                this.root = newNode;
            }
            else
            {
                InsertRecursive(root, newNode);
            }
        }

        private void InsertRecursive(TreeNode current, TreeNode newNode)
        {
            if (newNode.Value < current.Value)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                    return;
                }
                InsertRecursive(current.Left, newNode);
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                    return;
                }
                InsertRecursive(current.Right, newNode);
            }
        }
    }
}
