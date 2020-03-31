using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Low
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node()
        {
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }

        //https://leetcode.com/problems/n-ary-tree-postorder-traversal/
        public class NAryTreePostorderTraversalSolution
        {
            public IList<int> Postorder(Node root)
            {
                List<int> visited = new List<int>();
                Stack<Node> stack = new Stack<Node>();

                if (root==null) return visited;

                stack.Push(root);

                while(stack.Count>0)
                {
                    Node current = stack.Pop();   
                    visited.Add(current.val);

                    foreach(Node children in current.children)
                    {
                        stack.Push(children); 
                    }
                }
                
                visited.Reverse();
                return visited;
            }
        }
    }
}