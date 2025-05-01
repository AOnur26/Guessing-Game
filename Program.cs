namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "secret word";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Guess the secret word: ");
                    guess = Console.ReadLine();

                    if (guess == "1")
                    {
                        Console.WriteLine("hint1");
                    }
                    else if (guess == "2")
                    {
                        Console.WriteLine("hint2");
                    }
                    else if (guess == "3")
                    {
                        Console.WriteLine("hint3");
                    }
                    else
                    {
                        guessCount++;
                    }
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (secretWord == guess)
            {
                Console.WriteLine("!!! You Won !!!");
            }
            else
            {
                Console.WriteLine("!!! You Lost !!!");
            }

            Console.ReadLine();
        }
    }
}
