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


            string substr = GetLastNode("subbuc");

            GetDFSTreeTraversalPaths("a");


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


        private static void GetDFSTreeTraversalPaths(string path, bool showRetraceNode = false)
        {
            Console.WriteLine(path);
            string lastNode = GetLastNode(path);
            if (GetChildrenOfNode(lastNode) == null) return;
            foreach(string childNode in GetChildrenOfNode(lastNode))
            {
                GetDFSTreeTraversalPaths(path+childNode);
                if (showRetraceNode) Console.WriteLine(path);
            }
           
        }
    }
}