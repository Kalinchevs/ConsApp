namespace ConsApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Indexer ac = new Indexer();
            ac[0]=1;
            ac[1]=3;
            ac[2]=5;
            ac[3]=7;
            ac[4]=9;
            for(int i=0;i<5;i++)
                Console.WriteLine(ac[i]);
            Console.ReadKey();
        }
    }
}

