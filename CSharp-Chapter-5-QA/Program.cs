using System;

namespace Uppgift_5._14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            string[] svar = new string[4];

            Console.WriteLine($"Nu kommer {frågor.Length} för att svara på, Lycka till!\n");

            int score = 0;

            frågor[0] = "Vilket år slutade andra världskriget?";
            svar[0] = "1945";

            frågor[1] = "Vilket är nordens folkrikaste land?";
            svar[1] = "Sverige";

            frågor[2] = "Vilken är Sveriges största stad?";
            svar[2] = "Stockholm";

            frågor[3] = "Vilket år landade Neil Armstrong på månen?";
            svar[3] = "1969";

            for (int i = 0; i < frågor.Length; i++)
            {
                Console.WriteLine(frågor[i]);
                string användarensSvar = Console.ReadLine();

                if (användarensSvar == svar[i])
                {
                    Console.WriteLine("Du svarade rätt!");

                    score++;
                }
                else
                {
                    Console.WriteLine("Du svarade fel");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Klart.  Du fick {score} rätt.");
        }
    }
}