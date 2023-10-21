using System;

namespace MyApplication
{
    class Program
    {
        private enum Level
        {
            Low = 15,
            Medium,
            High = 51
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            //Console.WriteLine(Level[16]);
        }
    }
}