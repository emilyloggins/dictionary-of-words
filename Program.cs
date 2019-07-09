using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
/*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>() {
    {"Baby", "small child"},
    {"Father", "large male"},
    {"Mother", "large woman"},
    {"Grandparent", "wrinkly grape person"}
};

// Add several more words and their definitions
wordsAndDefinitions.Add("Sister", "medium female");

/*
    Use square brackets to get the definition of two of the
    words and then output them to the console
*/
Console.WriteLine(wordsAndDefinitions["Father"]);
Console.WriteLine(wordsAndDefinitions["Mother"]);

/*
    Below, loop over the wordsAndDefinitions dictionary to get the following output:
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
*/
foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
{
    Console.WriteLine($"The definition of {word.Key} is {word.Value}");
}        
}
}
}
