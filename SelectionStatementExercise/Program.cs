namespace SelectionStatementExercise
{
    public class Program
    {
          
        static void Main(string[] args)
        {

            var favNumber = 52;
            int userInput;
           
          
            do 
            {
                Console.WriteLine("Can you guess my favorite number?");
                userInput = int.Parse(Console.ReadLine());

                if (userInput <= 51)
                {
                    Console.WriteLine("Too low");
                }
                else if (userInput >= 53)
                {
                    Console.WriteLine("Too high");
                }
                else
                    Console.WriteLine("Spot on!");
            }
            while (userInput != favNumber);
        }
    }
}
