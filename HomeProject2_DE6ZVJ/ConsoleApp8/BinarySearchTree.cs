using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    //delegate void CallBackDelegate<TData>(TData instance);
    class BinarySearchTree<TKey,TValue> where TKey:IComparable
       
    {
        class BSTNode :Wizard
        {
            public TKey Key;
            public List<TValue> Value;
            public BSTNode Left;
            public BSTNode Right;

            public BSTNode()
            {
                Value=new List<TValue>();    
            }
            
            
        
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
                    currentRoot.Value.Add(newNode.Value[0]);


                }
            }
        }

        public void InsertWizard(TKey key, TValue value)
        {
            

                BSTNode newNode = new BSTNode();
                newNode.Value.Add(value);
                newNode.Key=key;
                newNode.Left = null;
                newNode.Right = null;


                RecursiveInsert(ref root, newNode);
 
        }

        void Traversal(BSTNode root)
        {
            if (root != null)
            {
                // In-order strategy
                Traversal(root.Left);
                for (int i = 0; i < root.Value.Count; i++)
                {
                    
                    Console.WriteLine((root.Value[i] as Wizard).Name);
                }
                Traversal(root.Right);
            }
        }

        public void Traversal(int searchQuality)
        {
            for (int i = 0; i < root.Value.Count; i++)
            {
                if (root.Key.CompareTo(searchQuality)==0)
                {
                    Traversal(root);
                }
               
                else
                {
                    throw new Exception("Can't find a wizard with quality : "+searchQuality);
                }
            }
            
            
        }








    }
}
