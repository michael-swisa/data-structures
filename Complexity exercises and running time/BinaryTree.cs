using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using Complexity_exercises_and_running_time;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            _root = DeleteRecursive(_root, value);
        }

        private TreeNode DeleteRecursive(TreeNode node, int value)
        {
            if (node == null)
                return node;
            // If key to be searched is in a subtree
            if (node.Value > value)
            {
                node.Left = DeleteRecursive(node.Left, value);
            }
            else if (node.Value < value)
            {
                node.Right = DeleteRecursive(node.Right, value);
            }
            else
            {
                // If root matches with the given key

                // Cases when root has 0 children or
                // only right child
                if (node.Left == null)
                {
                    return node.Right;
                }

                // When root has only left child
                if (node.Right == null)
                {
                    return node.Left;
                }

                // When both children are present
                int? succ = GetMinRecursive(node.Right);
                node.Value = succ.Value;
                node.Right = DeleteRecursive(node.Right, succ.Value);
            }
            return node;
        }

        public List<int> InOrder()
        {
            List<int> result = new List<int>();
            InOrderRecursive(_root, result);
            return result;
        }

        private List<int> InOrderRecursive(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                InOrderRecursive(node.Left, result);
                result.Add(node.Value);
                InOrderRecursive(node.Right, result);
            }
            return result;
        }

        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrderRecursive(_root, result);
            return result;
        }

        private List<int> PreOrderRecursive(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                result.Add(node.Value);
                PreOrderRecursive(node.Left, result);
                PreOrderRecursive(node.Right, result);
            }
            return result;
        }

        public void SaveToJsonInOrder(string filePath)
        {
            List<int> treeValues = InOrder();

            string jsonString = JsonSerializer.Serialize(treeValues);

            File.WriteAllText(filePath, jsonString);
        }

        public void LoadFromJson(string filePath)
        {
            // קריאת ה-JSON מתוך הקובץ
            string jsonString = File.ReadAllText(filePath);

            // המרה של ה-JSON לרשימת מספרים
            List<int>? treeValues = JsonSerializer.Deserialize<List<int>>(jsonString);

            // בניית העץ על בסיס הרשימה
            foreach (var value in treeValues)
            {
                Insert(value);
            }
        }
    }
}
