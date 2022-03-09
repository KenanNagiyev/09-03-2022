using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasLetter("salam eleykum","salam"));
        }
        static bool HasLetter(string name, string word)
        {
            for (int i = 0; i < name.Length; i++)
                for (int j = 0; j < word.Length; j++)
            
            {
                if (name[i] == word[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
