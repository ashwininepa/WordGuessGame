// // Console game to guess a word from a list of words

// Random rand = new Random();
// string[] words = ["dog", "cat", "boy", "girl"];
// string wordToGuess = words[rand.Next(0, words.Length)];

// bool hasWon = false;

// for(int i = 0; i < words.Length; i++)
// {
//     Console.WriteLine("Guess the word: ");

//     for(int j = 0; j < wordToGuess.Length; j++)
//     {
//         Console.WriteLine(words[j] + " ");
//     }
    
//     Console.WriteLine();

//     Console.WriteLine("Enter your guess: ");
//     string guess = Console.ReadLine();

//     if(guess == wordToGuess)
//     {
//         hasWon = true;
//         break;
//     }
// }

// if(hasWon)
// {
//     Console.WriteLine("You have won!");
// }
// else
// {
//     Console.WriteLine("You have lost! The word was: " + wordToGuess);
// }

for(int i = 0; i < 5; i++)

{

    Console.Write(i + "");

}