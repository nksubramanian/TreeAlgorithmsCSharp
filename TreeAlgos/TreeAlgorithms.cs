using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAlgos
{
    public static class TreeAlgorithms
    {
        public static Dictionary<string, List<string>> Tree = new Dictionary<string, List<string>>(){

                {"a", new List<string>(){"b","c","d"} },
                {"b", new List<string>(){"e","f"} },
                {"c", new List<string>(){"g"} },
                {"d", new List<string>(){"j","k"} },
                {"e", new List<string>(){} },
                {"f", new List<string>(){} },
                {"g", new List<string>(){"h","i"} },
                {"h", new List<string>(){} },
                {"i", new List<string>(){} },
                {"j", new List<string>(){} },
                {"k", new List<string>(){} },
               };

        private static string GetLastNode(string path)
        {
            return path[^1..];
        }

        private static List<string>? GetChildrenOfNode(string node)
        {
            if (Tree[node].Count == 0) return null;
            return Tree[node];
        }


        public static void GetDFSTreeTraversalPaths(string pathTraversed, ref List<string> pathsAlreadyTraversed)
        {
            Console.WriteLine("Check this " + pathTraversed);
            pathsAlreadyTraversed.Add(pathTraversed);
            string lastNode = GetLastNode(pathTraversed);
            if (GetChildrenOfNode(lastNode) == null) return;
            foreach (string childNode in GetChildrenOfNode(lastNode))
            {
                GetDFSTreeTraversalPaths(pathTraversed + childNode, ref pathsAlreadyTraversed);
            }

        }

        public static void GetBFSTreeTraversalPaths(string pathTraversed)
        {
            Queue pathsAlreadyTravesed = new Queue();
            Console.WriteLine(pathTraversed);
            pathsAlreadyTravesed.Enqueue(pathTraversed);
            while (true)
            {
                if (pathsAlreadyTravesed.Count == 0) break;
                pathTraversed = (string)pathsAlreadyTravesed.Dequeue();
                string lastNode = GetLastNode(pathTraversed);
                List<string>? children = GetChildrenOfNode(lastNode);
                if ((children != null) && children.Count > 0)
                {
                    foreach (string child in children)
                    {
                        Console.WriteLine(pathTraversed + child);
                        pathsAlreadyTravesed.Enqueue(pathTraversed + child);
                    }
                }


            }

        }

    }
}
