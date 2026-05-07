// Before you begin, make sure you open the folder named "palindrome" in an integrated terminal

// a variable to store the input
string? readResult;

// Introductory messages
Console.WriteLine("Welcome to this simple C# Palindrome Checker.");
Console.WriteLine("");
Console.WriteLine("Please input a word below:");

// Takes the user input
readResult = Console.ReadLine();
Console.WriteLine($"Word entered: {readResult}");

// Splits the entered word into a char array
char[] splitWord = readResult.ToCharArray();

// Reverses the order of the letters in the splitWord array
Array.Reverse(splitWord);

// Creates a new instance of System.String and passes splitWord as a constructor
string reversedWord = new string(splitWord);

// Displays the original message in reverse
Console.WriteLine($"Reversed message: {reversedWord}");

// If the original word is the same as the word reversed, it is a palindrome
if(readResult == reversedWord)
{
    Console.WriteLine("The word is a palindrome!");
}
else
{
    Console.WriteLine("The word is not a palindrome!");
}