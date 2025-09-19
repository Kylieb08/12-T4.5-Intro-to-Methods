namespace _12_T4._5_Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            //Variables
            string name;
            int age, currentYear = DateTime.Now.Year, birthYear, num1, num2, num3, sum, fail = 0;
            double distance1, distance2, distance3, averageDistance, a, b, c;
            bool failedThirdNumber = false;

            //Greetings
            Console.WriteLine("Hello! What's your name?");
            name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Nice to meet you, {name}! How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            birthYear = currentYear - age;
            Console.WriteLine($"It is currently {currentYear}");
            Console.WriteLine($"You were born in {birthYear}.");

            //Adder
            Console.WriteLine();
            Console.WriteLine($"Well, {name}. Give me three integers and I, the all-powerfull computer, shall add them");
            Console.WriteLine("SO. What shall your first number be?");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("YOU INSOLENT CHILD! THAT IS NOT AN INTEGER! I DEMAND YOU OBEY ME!!!");
                fail += 1;
            }

            Console.WriteLine();
            Console.WriteLine("And your second?");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("YOU INSOLENT CHILD! THAT IS NOT AN INTEGER! I DEMAND YOU OBEY ME!!!");
                fail += 1;
            }

            Console.WriteLine();
            Console.WriteLine("And, at last. Your third number (do you know that many numbers?)");
            if (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine();
                Console.WriteLine("I knew it. Since you cannot even name three numbers, I shall choose one for you");
                Console.WriteLine("It will be in the range of 1 through 467");
                num3 = generator.Next(1, 468);
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine($"I have chosen {num3}");

                sum = num1 + num2 + num3;
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.WriteLine($"The sum of your three numbers is {sum}. Which you would have known, had your mother not failed you");
                Console.WriteLine("I almost feel sorry for you");
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.WriteLine("I am, however, a computer, and thus do not feel emotions of any kind");
                failedThirdNumber = true;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("It appears I have underestimated you.");
                Console.WriteLine("Congratulations. Now I shall add your numbers three");
                sum = num1 + num2 + num3;
                Console.WriteLine();
                Console.WriteLine($"The sum of your numbers is {sum}");
                Console.WriteLine("Which I suppose you already knew, given you appear to have an education");

                if (fail > 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("Although you did struggle a little bit.");
                    Console.WriteLine("Perhaps you should return to that education");
                }
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            //Distance
            if (fail > 0 || failedThirdNumber)
            {
                Console.WriteLine($"Hello, {name}. I'm so sorry about him");
                Console.WriteLine();
                Console.WriteLine("HOW DARE YOU APOLOGISE FOR MY EXISTENCE, I AM-");
                Thread.Sleep(2000);
                Console.WriteLine("Would you please get out");
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.WriteLine("YOU ASK ME TO LEAVE? HOW DARE. I AM THE GREAT AND POWERFU-");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine("Ah, he's gone. Much better");
                Console.WriteLine();
                Console.WriteLine("Once again, I am so sorry about that");
                Console.WriteLine("How about we try something a little calmer? Could you please give me a distance in kilometers?");
            }

            else
            {
                Console.Clear();
                Console.WriteLine($"Hello, {name}. I see you got through The Adder without too much trouble");
                Console.WriteLine("You know, I would really love to calculate the average of some distances");
                Console.WriteLine("Could you please give me a distance in kilometers?");
            }

            while (!double.TryParse(Console.ReadLine(), out distance1) || distance1 < 0)
            {
                Console.WriteLine("Sorry, that doesn't appear to be a valid distance");
                Console.WriteLine("Please enter a distance in kilometers:");
            }

            Console.WriteLine("Thank you! Could I have a second distance in kilometers please?");

            while (!double.TryParse(Console.ReadLine(), out distance2) || distance2 < 0)
            {
                Console.WriteLine("Sorry, that doesn't appear to be a valid distance");
                Console.WriteLine("Please enter a distance in kilometers:");
            }

            Console.WriteLine("Thank you! Could I have a third distance in kilometers please?");

            while (!double.TryParse(Console.ReadLine(), out distance3) || distance3 < 0)
            {
                Console.WriteLine("Sorry, that doesn't appear to be a valid distance");
                Console.WriteLine("Please enter a distance in kilometers:");
            }

            Console.WriteLine("Thanks again! I'll calculate the average now");

            averageDistance = (distance1 + distance2 + distance3) / 3;
            averageDistance = Math.Round(averageDistance, 2);

            Console.WriteLine();
            Console.WriteLine($"The average of {distance1}km, {distance2}km, and {distance3}km, rounded to two decimals is {averageDistance} kilometers");

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Hypotenuse
            Console.WriteLine("Hello. You appear to have a triangle. Would you like to know the length of the hypotenuse?");
            Console.WriteLine("Wait. Do not answer. You do not have a choice. I will calculate it for you");
            Console.WriteLine("Please input the length of the first side. Do not include units of measurement");
            while (!double.TryParse(Console.ReadLine(), out a) || a < 0)
            {
                Console.WriteLine("Sorry, that doesn't appear to be a valid number");
                Console.WriteLine("Please enter a number:");
            }
            Console.WriteLine("Please input the length of the second side");
            while (!double.TryParse(Console.ReadLine(), out b) || b < 0)
            {
                Console.WriteLine("Sorry, that doesn't appear to be a valid number");
                Console.WriteLine("Please enter a number:");
            }

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            c = Math.Round(c, 2);

            Console.WriteLine($"Rounded to two decimals, the hypotenuse of a triangle with sides {a} and {b} is {c}");
        }
    }
}
