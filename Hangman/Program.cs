using System;
using System.IO;

namespace Hangman
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman - Finde das geheime Wort \n");

            //kaynak, rastgele secim, atama
            string[] woerterliste = File.ReadAllLines("/Users/macbook/Documents/GitHub/Hangman/Wortliste.txt");
            Random zufallzahlen = new Random();
            string gewaehtewort = woerterliste[zufallzahlen.Next(0, woerterliste.Length)];
            //Console.WriteLine(secilenkelime); rastgele kelimeyi gösterir


            //secilen kelime kadar _ olusturma
            char[] charakter = new char[gewaehtewort.Length];
            for (int i = 0; i < charakter.Length; i++)
            {
                charakter[i] = '_';
            }

            //Asil isleri olusturacagimiz döngü
            do
            {
                bool kol = false;

                //karakteri ekrana yazdirma
                foreach (var item in charakter)
                {
                    Console.Write(item + " ");
                }

                //ekrandan girdi isteme
                Console.WriteLine();
                Console.Write("Bitte ein Buchstaben eingeben : ");

                char buchstaben = char.Parse(Console.ReadLine());  //char harf = char.Parse(Console.ReadLine().ToUpper()); kücük veya büyük harf farketmez to upper ile

                //Girilen harf ile secilen kelimeyi kontrol etmek ve karakterin elemani ile degistirmek
                for (int i = 0; i < gewaehtewort.Length; i++)
                {
                    if (buchstaben == gewaehtewort[i])
                    {
                        charakter[i] = buchstaben;
                        kol = true;
                    }
                }

                if (buchstaben >= 'a' && buchstaben <= 'z')
                {
                    Console.WriteLine("Bitte Großbuchstabe eingeben : " + buchstaben);
                    Console.WriteLine("ungültige Eingabe");
                    Console.WriteLine();
                    if (gewaehtewort.Length == charakter.Length)
                    {
                        Console.WriteLine("Mit "+ ""+"Fehlerversuchen gefunden");
                    }
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
