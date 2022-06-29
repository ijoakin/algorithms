using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class GraphNode<T>
    {
        public T Value { get; set; }
        
        public CustomList<Edge<T>> Adjacents { get; set; }

        public GraphNode(T value)
        {
            Value = value;
        }
        
        public void Connect(GraphNode<T> target, double weight)
        {
            Edge<T> edge = new Edge<T>();

            edge.Target = target;
            edge.Weight = weight;
            this.Adjacents.Add(edge);
        }
    }
}
