using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACharacterCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada ees-ja perekonnanime
            //programm kuvab, mitu 'a' tähte on kasutaja ees-ja perekonnanimes kokku

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine().ToLower();

            string fullName = $"{ firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
            }
            
        }
    }
}
