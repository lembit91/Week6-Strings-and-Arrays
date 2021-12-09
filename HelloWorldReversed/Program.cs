using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldReversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World! lauset tagurpidi

            string helloWorld = "Hello, world!";

            for (int i = helloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(helloWorld[i]);
            }
        }
    }
}
