using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o', 'l' tähte on lauses "Hello World!"


            string helloWorld = "Hello, World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                { 
                    hCounter++;
                }
                else if (helloWorld[i] == 'o')
                {
                    oCounter++;
                }
                else if (helloWorld[i] == 'l')
                        {
                    lCounter++;
                }
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses {helloWorld} on {hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses {helloWorld} on {hCounter} 'h' täht.");
            }

            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses {helloWorld} on {oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses {helloWorld} on {oCounter} 'o' täht.");
            }
            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses {helloWorld} on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses {helloWorld} on {lCounter} 'l' täht.");
            }


        }
    }
}
