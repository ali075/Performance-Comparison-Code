using System.Collections.Generic;

namespace KoderDojo.Examples {
    public class Algorithms {
        public HashSet<T> DFS<T>(Graph<T> graph, T start) {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;
                
            var stack = new Stack<T>();
            stack.Push(start);

            while (stack.Count > 0) {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach(var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }

            return visited;
        }
    }
}
