// Check whether a given substring is present in the given string.
string testString = "Rock n roll is good for your soul";
string testSubstring = "roll is good";

if (testString.Contains("roll is good"))
{
    System.Console.WriteLine($"Text {testSubstring} found, substring is present.");
}

else
{
    System.Console.WriteLine($"Unfortunately {testSubstring} is not present in the main string");
    
}