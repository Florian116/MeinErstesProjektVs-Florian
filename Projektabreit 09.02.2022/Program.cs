using System;

namespace Projektabreit_09._02._2022
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int Note=0,schüler=0;
            double Notenschnitt = 0;
            int[] noten = new int[schüler];
            Console.WriteLine("Wie viele Schüler haben die Klassenarbeit geschrieben?");
            schüler = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < schüler; i++)
            {
                Console.WriteLine("Bitte Geben sie die Noten der schüler ein");

                Note = Convert.ToInt32(Console.ReadLine());

                Notenschnitt = Notenschnitt + Note;
            }
            Console.WriteLine("ihr durchschnitt lautet {0:F2}", Notenschnitt/schüler);
        }
    }
}           

               //Mit Florian und Mansour bearbeiet 
               
