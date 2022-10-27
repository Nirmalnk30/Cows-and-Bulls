using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Game
    {
        public static void Main(string[] args) // entry point of application
        {
            Console.WriteLine(" Welcome to Cows and Bulls \n");
            Console.WriteLine(" ********* \n");
            char[] a = { 'l', 'i', 'f', 'e' };//intialization
            int x = 0; int cows = 0;
            string word;
            for (int i = 0; x < 4; i++)
            {
                Console.WriteLine(" Guess the Word:");
                word = Console.ReadLine();
                char[] b = word.ToCharArray();
                try
                {
                    cows = 0;
                    int bulls = 0;
                    if (a[0] == b[0] && a[1] == b[1] && a[2] == b[2] && a[3] == b[3]) // cows check
                    {
                        Console.WriteLine(" \n Congrats..! YOU WIN...!"); // you correctly guess word, win msg print
                        x = 4;
                    }
                    else     // bulls check
                    {
                        if (b[0] == a[0]) cows++;
                        if (b[0] == a[1]) bulls++;
                        if (b[0] == a[2]) bulls++;
                        if (b[0] == a[3]) bulls++;

                        if (b[1] == a[0]) bulls++;
                        if (b[1] == a[1]) cows++;
                        if (b[1] == a[2]) bulls++;
                        if (b[1] == a[3]) bulls++;

                        if (b[2] == a[0]) bulls++;
                        if (b[2] == a[1]) bulls++;
                        if (b[2] == a[2]) cows++;
                        if (b[2] == a[3]) bulls++;

                        if (b[3] == a[0]) bulls++;
                        if (b[3] == a[1]) bulls++;
                        if (b[3] == a[2]) bulls++;
                        if (b[3] == a[3]) cows++;

                        Console.WriteLine($"{cows} cows {bulls} bulls"); // cows and bulls counting print
                    }
                }

                catch (Exception ex) // when try is problem then catch will be executed
                {
                    Console.WriteLine("Error" + ex.Message);
                }
            }

            Console.WriteLine("Game Over..."); // final statement

        }
    }
}