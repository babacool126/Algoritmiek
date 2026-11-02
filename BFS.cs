using System;
using System.Collections.Generic;

class Program
{
    static void BFS(
        Dictionary<int, List<int>> graph,
        int start)
    {
        Queue<int> queue = new();

        HashSet<int> visited = new();

        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();

            Console.WriteLine(node);

            foreach (int neighbor in graph[node])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);

                    queue.Enqueue(neighbor);
                }
            }
        }
    }

    static void Main()
    {
        // Define the graph and its connections
        var graph = new Dictionary<int, List<int>>
        {
            [1] = new() { 2, 3 },
            [2] = new() { 1, 4, 5 },
            [3] = new() { 1, 6 },
            [4] = new() { 2 },
            [5] = new() { 2 },
            [6] = new() { 3 }
        };

        // Start BFS at node 1
        BFS(graph, 1);
    }
}