using System;
using System.Diagnostics;

namespace Uppgift_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] siffror = new int[3];
            Console.WriteLine("Skriv in tre tal");
            try
            {


                siffror[0] = int.Parse(Console.ReadLine());
                siffror[1] = int.Parse(Console.ReadLine());
                siffror[2] = int.Parse(Console.ReadLine());

                Console.WriteLine(siffror[0] + siffror[1] + siffror[2]);
            }
            catch ( Exception e )
            {
                Console.WriteLine("Skriv bara in siffror, " + e.Message);
            }
        }
    }
}