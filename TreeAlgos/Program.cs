namespace TreeAlgos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Children0f = new Dictionary<string, List<string>>(){
                        {"UK", new List<string>(){"New York","London","Mumbai", "Chicago"} 
                        
               }  
               };

            string substr = GetLastNode("subbuc");
            var t = Children0f["UK"];
            Console.WriteLine(substr);
        }

        private static string GetLastNode(string nodes)
        {
            return nodes[^1..];
        }
    }
}