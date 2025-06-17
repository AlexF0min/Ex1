// Check whether a given substring is present in the given string.
// string testString = "Rock n roll is good for your soul";
// string testSubstring = "roll is good";

// input 
Console.Write("Please input your text here: ");
string inputString = Console.ReadLine();

Console.Write("Search: ");
string searchQuery = Console.ReadLine();



if (inputString.Contains(searchQuery))
{
    System.Console.WriteLine(@$"Text ""{searchQuery}"" found, substring is present.");
}

else
{
    System.Console.WriteLine(@$"Unfortunately ""{searchQuery}"" is not present in the main string.");

}