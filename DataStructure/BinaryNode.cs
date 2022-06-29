using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BinaryNode<T> where T: IComparable
    {

        public T Value { get; set; }

        public BinaryNode<T> LeftChild { get; set; }

        public BinaryNode<T> RightChild { get; set; }

        public BinaryNode()
        {
            
        }

        public BinaryNode(T value)
        {
            Value = value;
            //LeftChild = new BinaryNode<T>();
            //RightChild = new BinaryNode<T>();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
