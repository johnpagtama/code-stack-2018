using System;

namespace MiniChallenge8
{
    class Program
    {
        static void Main(string[] args)
        {
            loadGame();
        }

        // Load game
        private static void loadGame()
        {
            do
            {
                int difficulty = selectDifficulty();
                playGame(difficulty);

            } while (replay());
        }

        // Select difficulty
        private static int selectDifficulty()
        {
            int selection;

            Console.WriteLine("Select Difficulty:\n[1] Easy\n[2] Medium\n[3] Hard");

            selection = isDifficultValid();

            return selection;
        }

        // Validate input for menu
        private static int isDifficultValid()
        {
            int val;
            bool parsedInput = Int32.TryParse(Console.ReadLine(), out val);

            while (val < 1 || val > 3 || !parsedInput) 
            {
                Console.WriteLine("Enter 1, 2, or 3 to select difficulty");
                parsedInput = Int32.TryParse(Console.ReadLine(), out val);
            }

            return val;
        }

        // Play game
        private static void playGame(int difficulty)
        {
            int secretNum;
            int guess;

            switch (difficulty)
            {
                case 1:
                    secretNum = genEasy();
                    guess = enterGuess();
                    isCorrect(secretNum, guess);
                    break;
                case 2:
                    secretNum = genMedium();
                    guess = enterGuess();
                    isCorrect(secretNum, guess);
                    break;
                case 3:
                    secretNum = genHard();
                    guess = enterGuess();
                    isCorrect(secretNum, guess);
                    break;
            }
        }

        // Generate number between 1 -> 10
        private static int genEasy()
        {
            Random r = new Random();
            int secretNum = r.Next(1, 11);

            return secretNum;
        }

        // Generate number between 1 -> 50
        private static int genMedium()
        {
            Random r = new Random();
            int secretNum = r.Next(1, 51);

            return secretNum;
        }

        // Generate number between 1 -> 100
        private static int genHard()
        {
            Random r = new Random();
            int secretNum = r.Next(1, 101);

            return secretNum;
        }

        // Enter guess
        private static int enterGuess()
        {
            Console.WriteLine("Thinking of a number between 1 and 10...\n Guess my number: ");
            int guess = isGuessValid();

            return guess;
        }

        // Validate input for guess
        private static int isGuessValid()
        {
            int val;
            bool parsedInput = Int32.TryParse(Console.ReadLine(), out val);

            while (!parsedInput)
            {
                Console.WriteLine("You must enter a number");
                parsedInput = Int32.TryParse(Console.ReadLine(), out val);
            }

            return val;
        }

        // Check if guess is correct
        private static void isCorrect(int secretNum, int guess)
        {
            if (secretNum == guess)
            {
                Console.WriteLine($"Yes the answer was {secretNum}");
                numAttempts();
            }
            else if (guess < secretNum)
            {
                Console.WriteLine("My number is higher");
            }
            else
            {
                Console.WriteLine("My number is lower");
            }
        }

        // Track attempts
        private static void numAttempts()
        {
            int numAttempts = 0;
            numAttempts++;

            Console.WriteLine($"It took you {numAttempts} to get it right");
        }

        // Loop program
        private static bool replay()
        {
            bool loop = true;
            char playAgain;

            while (loop)
            {
                Console.WriteLine("Would you like to play again? Y or N");
                playAgain = isPlayAgainValid();

                loop = playAgain.ToString().ToUpper() == 'Y'.ToString();
            }

            return loop;
        }

        // Validate input for replay
        private static char isPlayAgainValid()
        {
            char val = Console.ReadLine()[0];

            while (val.ToString().ToUpper() != 'Y'.ToString() && val.ToString().ToUpper() != 'N'.ToString())
            {
                Console.WriteLine("Input cannot be a number and must be Y or N");
                val = Console.ReadLine()[0];
            }

            return val;
        }
    }
}
