using System;

namespace Methoden_implementieren
{
    class Program
    {

            static void Main(string[] args)
            {
                Console.WriteLine("Geben sie bitte die Anzahl der Worte an");
                int durchlauf = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Geben sie bitte das Wort ein");
                string text = Console.ReadLine();
                int anzahl = 0;
                anzahl = ausgabeTextMalX(durchlauf, text);

                Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);

            }

            static int ausgabeTextMalX(int durchlauf, string text)
            {

                for (int i = 0; i < durchlauf; i++)
                {
                    Console.WriteLine(text);
                }


                return text.Length * durchlauf;
            }

        
    }
}