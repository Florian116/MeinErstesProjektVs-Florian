using System;

namespace SchleifenA5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());


            for (int i = -x; i <= x; i += 2) //i++ -> i=i+1 -> i+=1      
            {
                Console.WriteLine(i);
            }
        }
    }
}
