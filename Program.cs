namespace _12_T4._5_Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER for a joke:");
            Console.ReadLine();
            Joke(); //This "calls" or "invokes" the method Joke()
        }

        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code.");
        }
    }
}
