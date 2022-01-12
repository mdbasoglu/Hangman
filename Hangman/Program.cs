using System;
using System.IO;

namespace Hangman
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman - Finde das geheime Wort \n");

            //Wortliste wählen, schreiben, ausdrucken
            string[] woerterliste = File.ReadAllLines("/Users/macbook/Documents/GitHub/Hangman/Wortliste.txt");
            Random zufallzahlen = new Random();
            string gewaehtewort = woerterliste[zufallzahlen.Next(0, woerterliste.Length)];
            //Console.WriteLine(secilenkelime); rastgele kelimeyi gösterir


            // _ generieren
            char[] charakter = new char[gewaehtewort.Length];
            for (int i = 0; i < charakter.Length; i++)
            {
                charakter[i] = '_';
            }

            //MAIN PROGRAMMIEREN
            do
            {
                bool kol = false;

                //Sehen von Charakter
                foreach (var item in charakter)
                {
                    Console.Write(item + " ");
                }

                //Buchstaben schreiben
                Console.WriteLine();
                char buchstaben = char.Parse(Console.ReadLine());  //char buchstaben = char.Parse(Console.ReadLine().ToUpper()); kücük veya büyük harf farketmez to upper ile


                //Girilen harf ile secilen kelimeyi kontrol etmek ve karakterin elemani ile degistirmek
                for (int i = 0; i < gewaehtewort.Length; i++)
                {
                    if (buchstaben == gewaehtewort[i])
                    { 
                        charakter[i] = buchstaben;
                        kol = true;
                    }
                }
               
                

                //Klein Groß Schreiben
                if (buchstaben >= 'a' && buchstaben <= 'z')
                {
                    Console.WriteLine("Bitte Großbuchstabe eingeben : " + buchstaben);
                    Console.WriteLine("ungültige Eingabe");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Bitte Großbuchstabe eingeben : " + buchstaben);
                    Console.WriteLine();
                }
                

                /*
                //Wenn wir Punkte geben möchten
                if (kol == true)
                {
                    punkte += 30;
                }
                else
                {
                    punkte -= 30;
                }
                Console.WriteLine("Punkte Status" + punkte);
                */
            } while (true);
            

            Console.ReadKey();
        }
    }
}
