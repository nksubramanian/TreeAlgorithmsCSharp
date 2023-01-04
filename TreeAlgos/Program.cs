namespace TreeAlgos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substr = GetLastNode("subbuc");

            Console.WriteLine(substr);
        }

        private static string GetLastNode(string nodes)
        {
            return nodes[^1..];
        }
    }
}