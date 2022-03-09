using System;

namespace SchleifenA5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());


            for (int i = -x; i <= x; i += 2)  
            {
                Console.WriteLine(i);
            }
        }
    }
}