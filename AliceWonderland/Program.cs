using System;

namespace AliceWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord;
            string wonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine($"\"{wonderland}\"");

            Console.WriteLine("Enter a word to be searched: ");
            inputWord = Console.ReadLine();

            bool containsSearchResult = wonderland.Contains(inputWord);
            Console.WriteLine($"{containsSearchResult}");

            int first = wonderland.IndexOf("methods") + "methods".Length;
            int last = wonderland.LastIndexOf("methods");
            string str2 = wonderland.Substring(first, last - first);
            Console.WriteLine($"Substring between \"methods\" and \"methods\": '{str2}'");


        }
    }
}
