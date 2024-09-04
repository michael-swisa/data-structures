using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Complexity_exercises_and_running_time
{
    internal class BinaryTree
    {
        private TreeNode _root;

        public BinaryTree()
        {
            this._root = null;
        }

        public void Insert(int value)
        {
            _root = InsertRecursive(_root, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
                return node;
            }
            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);
            else // value >= node.Value
                node.Right = InsertRecursive(node.Right, value);
            return node;
        }

        public bool Find(int value)
        {
            return FindRecursive(_root, value);
        }

        private bool FindRecursive(TreeNode node, int value)
        {
            if (node == null)
                return false;

            if (node.Value == value)
                return true;

            if (value < node.Value)
                return FindRecursive(node.Left, value);

            return FindRecursive(node.Right, value);
        }

        public int? GetMin()
        {
            return GetMinRecursive(_root);
        }

        private int? GetMinRecursive(TreeNode node)
        {
            if (node == null)
                return null;

            while (node.Left != null)
            {
                node = node.Left;
            }
            return node.Value;
        }

        public int? GetMax()
        {
            return GetMaxRecursive(_root);
        }

        private int? GetMaxRecursive(TreeNode node)
        {
            if (node == null)
                return null;

            while (node.Right != null)
            {
                node = node.Right;
            }
            return node.Value;
        }

        public void Delete(int value)
        {
            DeleteRecursive(_root, value);
        }

        private void DeleteRecursive(TreeNode node, int value) { }
    }
}
