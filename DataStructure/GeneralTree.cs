using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class GeneralTree<T> where T: IComparable
    {

        private GeneralNode<T> root { get; set; }

        public GeneralTree(T value)
        {
            root = new GeneralNode<T>(value);
        }

        public void InsertValue()
        {

        }
    }
}
