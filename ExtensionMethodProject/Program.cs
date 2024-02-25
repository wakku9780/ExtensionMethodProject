namespace ExtensionMethodProject
{
    internal class Program
    {
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2"); 
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.Test1();
            p.Test2();
            Console.ReadLine();
        }
    }
}
