using System;
using System.IO;

namespace Hangman
{
    class MainClass
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            string[] worte = File.ReadAllLines("/Users/macbook/Documents/GitHub/Hangman/Hangman/Wortliste.txt");

            int index = rand.Next(worte.Length);
            
            string zufallwort = worte[index];

            for (int i = 0; i < zufallwort.Length ; i++)
            {
                Console.Write("_");
                
            }
            Console.WriteLine();




            /*
            for (int i = 0; i < worte.Length; i++) //Das Lesen jeder Zeilen von txt File
            {
                Console.WriteLine(worte[i] + ' ');    
            }
            */


            Console.WriteLine("Hangman - Finde das geheime Wort \n");
            Console.WriteLine("");




        }



        public static void wortliste()
        {
        }


    }
}
