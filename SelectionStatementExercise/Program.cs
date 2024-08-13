using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose which program you want!");
            string selection;
            do
            {
                selection = Console.ReadLine();//ReadLine goes in loop so it keeps asking for input
                switch (selection) //switch case used for future proofing
                {
                    case "Number Game":
                    {
                        NumberGame();
                        Console.WriteLine("Thank you for playing!");
                        break;
                    }
                    case "Favorite Subject":
                    {
                        SchoolSubject();
                        Console.WriteLine("Thank you for talking with me!");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Input.\nValid inputs are:\nNumber Game\nFavorite Subject");
                        selection = null;
                        break;
                    }
                }
            } while (selection == null);//this is to end the program when either option is completed
        }

        public static void NumberGame()
        {
            Random r = new Random();
            int favNum = r.Next(1, 21);
            Console.WriteLine("Guess my favorite number.\nHint it's between 1 and 20");
            int userInput;//variable declared here so loop can read it
            do
            {
                userInput = int.Parse(Console.ReadLine());
                if (favNum < userInput)
                {
                    Console.WriteLine("Your answer was too high!");
                }
                else if (favNum > userInput)
                {
                    Console.WriteLine("Your number was too low!");
                }
                else
                {
                    Console.WriteLine("You guessed correctly!");
                }
            } while (favNum != userInput);//loops input until guessed correctly
        }

        public static void SchoolSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSub = Console.ReadLine();
            switch (favSub)
            {
                case "Math":
                    Console.WriteLine("Math is cool because it's all about problem solving.");
                    break;
                case "Chemistry":
                    Console.WriteLine("Chemistry is awesome because it involves seeing reactions happen.");
                    break;
                case "Geography":
                    Console.WriteLine("Geography is fun because you get to learn more about other cultures.");
                    break;
                case "World History":
                    Console.WriteLine("World history is great because you get to take a glimpse into the past.");
                    break;
                case "Lunch":
                    Console.WriteLine("I don't think lunch is a subject, but I enjoy a good meal, too.");
                    break;
                default:
                    Console.WriteLine("Wow, good choice. I didn't think of that!");
                    break;
            }
        }
    }
}
