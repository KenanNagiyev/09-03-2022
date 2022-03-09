using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasLetter("salam eleykum","salam"));
        }
        static bool HasLetter(string name, string letter)
        {
            for (int i = 0; i < name.Length; i++)
                for (int j = 0; j < letter.Length; j++)
            
            {
                if (name[i] == letter[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
