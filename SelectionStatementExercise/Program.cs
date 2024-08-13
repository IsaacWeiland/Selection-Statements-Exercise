namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            switch (Console.ReadLine())
            {
                case "Number Game":
                {
                    NumberGame();
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Input");
                    break;
                }
            }
            
        }

        public static void NumberGame()
        {
            Random r = new Random();
            int favNum = r.Next(1, 21);
            Console.WriteLine("Guess my favorite number.\nHint it's between 1 and 20");
            int userInput;
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
            } while (favNum != userInput);
        }
    }
}
