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
            TreeAlgorithms.GetDFSTreeTraversalPaths("a", ref pathsAlreadyTraversed);
            TreeAlgorithms.GetBFSTreeTraversalPaths("a");

        }

       

    }
}