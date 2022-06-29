using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class GeneralNode<T>
    {
        public T Value { get; set; }

        public CustomList<T> Childs { get; set; }

        public GeneralNode(T value)
        {
            this.Value = value;
            this.Childs = new CustomList<T>();
        }

    }
}
