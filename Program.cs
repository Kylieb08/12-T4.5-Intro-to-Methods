namespace _12_T4._5_Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int bugs;
            string anotherJoke;

            //Tutorial
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

            Console.WriteLine("Press ENTER to continue to the assignment");
            Console.ReadLine();
            Console.Clear();

            //Assignment
            Console.WriteLine("Here is some ASCII art");
            Console.WriteLine();
            Console.WriteLine("Here is a deer");
            DrawDeer();
            Console.WriteLine();
            Console.WriteLine("and an owl");
            DrawOwl();
            Console.WriteLine();
            Console.WriteLine("and side six of a die");
            DrawDieSix();
            Console.WriteLine();
            Console.WriteLine("Here is a knock knock joke");
            KnockKnockJoke();
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

        //Assignment

        //ASCII Art
        public static void DrawDeer()
        {
            Console.WriteLine("(             )             ");
            Console.WriteLine(" `--(_   _)--'              ");
            Console.WriteLine("      Y-Y                   ");
            Console.WriteLine("     /@@ \\                 ");
            Console.WriteLine("    /     \\                ");
            Console.WriteLine("    `--'.  \\             , ");
            Console.WriteLine("        |   `.__________/)  ");
        }

        public static void DrawOwl()
        {
            Console.WriteLine(" (\\_._/)");
            Console.WriteLine(" ( o o )");
            Console.WriteLine(" /  V  \\");
            Console.WriteLine("/(  _  )\\");
            Console.WriteLine("  ^^ ^^");
        }

        public static void DrawDieSix()
        {
            Console.WriteLine(" ------- ");
            Console.WriteLine("| *   * |");
            Console.WriteLine("| *   * |");
            Console.WriteLine("| *   * |");
            Console.WriteLine(" ------- ");
        }

        public static void KnockKnockJoke()
        {
            string whoThere, lettuceWho;
            Console.WriteLine();
            Console.WriteLine("Knock knock");
            whoThere = Console.ReadLine();
            while (whoThere.ToLower() != "who's there" && whoThere.ToLower() != "who's there?" && whoThere.ToLower() != "whos there?" && whoThere.ToLower() != "whos there")
            {
                Console.WriteLine("No, you're supposed to go along with the joke");
                Console.WriteLine("Try again");
                whoThere = Console.ReadLine();
            }

            Console.WriteLine("Lettuce");
            lettuceWho = Console.ReadLine();
            while (lettuceWho.ToLower() != "lettuce who" && lettuceWho.ToLower() != "lettuce who?")
            {
                Console.WriteLine("No, you're supposed to go along with the joke");
                Console.WriteLine("Try again");
                lettuceWho = Console.ReadLine();
            }
            Console.WriteLine("Lettuce in. We're cold");
        }
    }
}
