using System;

namespace Developer3
{
    class Parachute {
        string[] words = {"holes", "house", "ghost", "chair", "adore", "adopt", "drive", "heart", "large", "laugh", "learn", "final", "blush"}
        List<string> wordList = new List<string>(words);
        int lives = 4;
        while (lives > 0) {
            Console.WriteLine("Guess a letter between (a-z):");
            string guess = Console.Readline();
            letterGuess();
            totalGuesses();
        }
    }
}


/// Guessing a Letter
class  letterGuess{
    if string guess = wordValue; {
        Console.WriteLine("Nice Guess");
    }
    else {
        Console.WriteLine("Incorrect Letter")
        lives -1
    }
}


/// Amount of Turns
class totalGuesses {
    if lives = 0{
        Console.WriteLine("You Lose")
    }
}
