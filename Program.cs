namespace _12_T4._5_Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bugs;
            string anotherJoke;

            Console.WriteLine("Press ENTER for a joke:");
            Console.ReadLine();
            Joke(); //This "calls" or "invokes" the method Joke()
            Console.WriteLine();
            Console.WriteLine("Would you like to hear another joke?");
            anotherJoke = Console.ReadLine();

            if (anotherJoke.ToLower() == "yes" || anotherJoke.ToLower() == "y")
            {
                Console.WriteLine("How many bugs are in your code?");
                Int32.TryParse(Console.ReadLine(), out bugs);
                Joke(bugs);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("oh");
                Thread.Sleep(1000);
                Console.WriteLine("ok");
                Thread.Sleep(1000);
                Console.WriteLine("Goodbye");
            }
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

        public static void Joke(int numBugs)
        {
            Console.WriteLine();
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((++numBugs) + " little bugs in the code.");
        }
    }
}
