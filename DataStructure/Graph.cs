namespace DataStructure
{
    public class Graph<T>
    {
        public GraphNode<T>[] nodes { get; set; }
        public int NumberOfNodes { get; set; }

        private Dictionary<T, GraphNode<T>> hashNodes { get; set; }

        public Graph()
        {
            NumberOfNodes = 0;
            nodes = new GraphNode<T>[50];
        }

        public void InsertNode(T value)
        {
            NumberOfNodes++;
            GraphNode<T> node = new GraphNode<T>(value);

            nodes[NumberOfNodes] = node;
            hashNodes.Add(value, node);

        }
        public GraphNode<T> SearchNode(T data)
        {
            GraphNode<T> nodeDest = hashNodes[data];

            return nodeDest;
        }

        public void Connect(T source, T target, double? weight)
        {
            var sourceNode = SearchNode(source);
            var targetNode = SearchNode(target);

            Edge<T> newEdge = new Edge<T>();

            newEdge.Target = targetNode;
            if (weight != null) newEdge.Weight = weight.Value;

            sourceNode.Adjacents.Add(newEdge);
        }

    }
}
