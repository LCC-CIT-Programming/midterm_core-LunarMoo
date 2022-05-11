using System;

namespace Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Eliza Response.");
            Console.WriteLine();
            Console.WriteLine("Please enter a Statement so Eliza can Respond.");
            string input =  Console.ReadLine();

            string answer = CreateElizaResponse(input);
            Console.WriteLine("Response :" + answer);
        }

        static bool IsVowel(char c)
        {
            switch (c)
            {
                
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    return true;
                default:
                    return false;
            }
        }
        static string CreateElizaResponse(string s) 
        {
            string answer;
            if (IsVowel(s[6]))
                answer = "Tell me more";
            else
                answer = "You have strong feelings about that!";
            return answer;
        }



    }
}

