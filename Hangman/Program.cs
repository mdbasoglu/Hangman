using System;
using System.IO;

namespace Hangman
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman - Finde das geheime Wort \n");
            int Fehlersuche = 0;

            //Wortliste wählen, schreiben, ausdrucken
            string[] woerterliste = File.ReadAllLines("/Users/macbook/Documents/GitHub/Hangman/Wortliste.txt");
            Random zufallzahlen = new Random();
            string gewaehtewort = woerterliste[zufallzahlen.Next(0, woerterliste.Length)];

            // _ generieren
            char[] charakter = new char[gewaehtewort.Length];
            for (int i = 0; i < charakter.Length; i++)
            {
                charakter[i] = '_';
            }


            //MAIN PROGRAMMIEREN
            do
            {
                //var
                bool etwas = false;

                //Sehen von Charakter
                foreach (var item in charakter)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                //Buchstaben schreiben
                char buchstaben = char.Parse(Console.ReadLine());  //char buchstaben = char.Parse(Console.ReadLine().ToUpper()); kücük veya büyük harf farketmez to upper ile

                //Girilen harf ile secilen kelimeyi kontrol etmek ve karakterin elemani ile degistirmek
                for (int i = 0; i < gewaehtewort.Length; i++)
                {
                    if (buchstaben == gewaehtewort[i])
                    { 
                        charakter[i] = buchstaben;
                        etwas = true;
                    }
                }

                //Counter für den Fehlerversuch
                Console.WriteLine("bisher "+Fehlersuche+" Fehlversuche");
                if((buchstaben >= 'A' && buchstaben <= 'Z') == false)
                {
                    Fehlersuche++;
                }

                //Klein Groß Schreiben
                if (buchstaben >= 'a' && buchstaben <= 'z')
                {
                    
                    Console.WriteLine("ungültige Eingabe");
                    Console.WriteLine("Bitte Großbuchstabe eingeben : " + buchstaben);
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

            Console.WriteLine("Mit " + Fehlersuche + " Fehlversuchen gefunden");

        }
    }
}
