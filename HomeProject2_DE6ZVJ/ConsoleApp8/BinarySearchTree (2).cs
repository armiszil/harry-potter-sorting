using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class BinarySearchTree<TKey,TValue> where TKey:IComparable

    {
        class BSTNode
        {
            public TKey Key;
            public List<TValue> Value;
            public BSTNode Left;
            public BSTNode Right;
        }
        BSTNode root;

        void RecursiveInsert(ref BSTNode currentRoot, BSTNode newNode)
        {
            if (currentRoot == null)
            {
                currentRoot = newNode;
            }
            else
            {
                if (currentRoot.Key.CompareTo(newNode.Key) > 0)
                {
                    RecursiveInsert(ref currentRoot.Left, newNode);
                }
                else if (currentRoot.Key.CompareTo(newNode.Key) < 0)
                {
                    RecursiveInsert(ref currentRoot.Right, newNode);
                }
                else 
                {
                    currentRoot.Value.Append(newNode.Value);

                }
            }
        }

        public void InsertWizard(TKey key, TValue value)
        {
            

                BSTNode newNode = new BSTNode();
            newNode.Value.Append(value);
                newNode.Key=key;
                newNode.Left = null;
                newNode.Right = null;


                RecursiveInsert(ref root, newNode);
            



        }








    }
}
