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

            GetDFSTreeTraversalPaths("a", ref pathsAlreadyTraversed);

            var f = pathsAlreadyTraversed;

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


        private static void GetDFSTreeTraversalPaths(string pathTraversed, ref List<string> pathsAlreadyTraversed, bool showRetraceNode = false)
        {
            Console.WriteLine("Check this "+pathTraversed);
            pathsAlreadyTraversed.Add(pathTraversed);
            string lastNode = GetLastNode(pathTraversed);
            if (GetChildrenOfNode(lastNode) == null) return;
            foreach(string childNode in GetChildrenOfNode(lastNode))
            {
                GetDFSTreeTraversalPaths(pathTraversed + childNode, ref pathsAlreadyTraversed);
                if (showRetraceNode) Console.WriteLine(pathTraversed);
            }
           
        }
    }
}