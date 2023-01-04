using System.Collections;

namespace TreeAlgos
{
    internal class Program
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
        static void Main(string[] args)
        {
            List<string> pathsAlreadyTraversed = new List<string>();
            //GetDFSTreeTraversalPaths("a", ref pathsAlreadyTraversed);
            string lastNode = GetLastNode("ab");

            GetBFSTreeTraversalPaths("a");






        }

        private static string GetLastNode(string path)
        {
            return path[^1..];
        }

        private static List<string>? GetChildrenOfNode(string node)
        {
            if (Tree[node].Count == 0) return null;
            return Tree[node];
        }


        private static void GetDFSTreeTraversalPaths(string pathTraversed, ref List<string> pathsAlreadyTraversed)
        {
            Console.WriteLine("Check this "+pathTraversed);
            pathsAlreadyTraversed.Add(pathTraversed);
            string lastNode = GetLastNode(pathTraversed);
            if (GetChildrenOfNode(lastNode) == null) return;
            foreach(string childNode in GetChildrenOfNode(lastNode))
            {
                GetDFSTreeTraversalPaths(pathTraversed + childNode, ref pathsAlreadyTraversed);
            }
           
        }

        private static void GetBFSTreeTraversalPaths(string pathTraversed)
        {
            Queue pathsAlreadyTravesed = new Queue();
            Console.WriteLine(pathTraversed);
            if (GetChildrenOfNode(GetLastNode(pathTraversed))==null) return;
            pathsAlreadyTravesed.Enqueue(pathTraversed);
            while (true)
            {
                if (pathsAlreadyTravesed.Count == 0) break;
                pathTraversed = (string)pathsAlreadyTravesed.Dequeue();
                string lastNode = GetLastNode(pathTraversed);
                List<string>? children =  GetChildrenOfNode(lastNode);
                if((children!=null) && children.Count>0)
                {
                    foreach(string child in children)
                    {
                        Console.WriteLine(pathTraversed + child);
                        pathsAlreadyTravesed.Enqueue(pathTraversed + child);
                    }
                }
 

            }
                
        }

    }
}