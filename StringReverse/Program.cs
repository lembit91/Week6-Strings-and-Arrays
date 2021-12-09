using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutaja eesnime tagurpidi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            for(int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            }
        }
    }
}
