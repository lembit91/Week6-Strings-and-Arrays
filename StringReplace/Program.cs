using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Hello World!" tärniga (*)

            string helloW = "Hello World!";

            /*for(int i = 0; i < helloW.Length; i++)
            {
                helloW[i] = '*';
            }*/

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);

        }
    }
}
