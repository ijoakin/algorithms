namespace DataStructure
{
    public class BinaryTree<T> where T: IComparable
    {
        private BinaryNode<T> root;

        public void InsertValue(T value)
        {
            var NewNode = new BinaryNode<T>(value);

            if (root == null) {
                root = NewNode;
            }
            else {
                BinaryNode<T> current = root;
                BinaryNode<T> parent;
                while (true)
                {
                    parent = current;
                    if (value.CompareTo(current.Value) == -1)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = NewNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = NewNode;
                            break;
                        }
                    }
               }
            }
        }
        public T minValue()
        {
            BinaryNode<T> current = root;

            if (root == null)
                return default(T);


            while (current.LeftChild != null)
            {
                current = current.LeftChild;   
            }

            return current.Value;
        }
        public T maxValue()
        {
            BinaryNode<T> current = root;

            if (root == null)
                return default(T);

            while (current.RightChild != null)
            {
                current = current.RightChild;
            }

            return current.Value;
        }

        public void PrintInOrder()
        {
            PrintInOrder(root);
        }
        public void PrintPreOrder()
        {
            PrintPreOrder(root);
        }
        public void PrintPostOrder()
        {
            PrintPostOrder(root);
        }
        private void PrintInOrder(BinaryNode<T> node)
        {
            if (node != null)
            {
                PrintInOrder(node.LeftChild);
                Console.WriteLine(node.Value);
                PrintInOrder(node.RightChild);
            }
        }

        private void PrintPreOrder(BinaryNode<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PrintInOrder(node.LeftChild);
                PrintInOrder(node.RightChild);
            }
        }

        private void PrintPostOrder(BinaryNode<T> node)
        {
            if (node != null)
            {
                PrintInOrder(node.LeftChild);
                PrintInOrder(node.RightChild);
                Console.WriteLine(node.Value);
            }
        }
    }
}
