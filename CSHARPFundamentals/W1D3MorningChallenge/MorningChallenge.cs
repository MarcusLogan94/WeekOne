using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace W1D3MorningChallenge
{
    [TestClass]
    public class MorningChallenge
    {
        [TestMethod]
        public static void main()
        {
            string word = "Supercalifragilisticexpialidocious";

            for(int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                Console.WriteLine(letter);
            }

            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'L')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    
                    Console.WriteLine("Not an i");
                }
            
            }

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("The length of " + word + " is: " + word.Length);

        }
    }
}
