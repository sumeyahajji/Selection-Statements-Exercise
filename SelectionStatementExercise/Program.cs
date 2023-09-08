namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            var a = new Random();//used for generating random numbers
            var favNumber = a.Next(20, 30);
            

            Console.WriteLine("Guess a random number:");//It prompts the user to input their guess.
            var userInput = int.Parse(Console.ReadLine());//reads user input and convert it into integer and stores it in variable called userinput

            if (favNumber < userInput)
            {
                Console.WriteLine("Too low!");

            }
            else if ( favNumber > userInput)
            {
                Console.WriteLine("Too high");
            }

            else
            {
                Console.WriteLine("Congratulation you guessed it well!");
            }




        }
    }
}
