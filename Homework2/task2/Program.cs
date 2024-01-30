using System.Collections.Generic;
List<string> words = new List<string>()
{
    "Hello",
    "World",
    "I",
    "am",
    "from",
    "Tajikistan",
    "."
};
string concat = string.Join(" ", words);

System.Console.WriteLine("The concatenated string is: " + concat);