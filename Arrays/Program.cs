using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[6] { 456545 , 56 ,34 ,1 , 345 ,245 };
           Array.Sort(array);
           Array.Reverse(array);
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.WriteLine(array[5]);
            Console.ReadKey();


        }   

    }
}
