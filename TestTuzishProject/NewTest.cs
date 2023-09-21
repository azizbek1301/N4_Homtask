using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TestTuzishProject
{
    public class NewTest
    {
        public static void TestNew()
        {
            Console.WriteLine("Fan nomi");
            var subject=Console.ReadLine();
            Console.WriteLine("Savolni yozing");
            var savol=Console.ReadLine();
            Console.WriteLine("A");
            var a=Console.ReadLine();
            Console.WriteLine("B");
            var b=Console.ReadLine();
            Console.WriteLine("C");
            var c=Console.ReadLine();
            Console.WriteLine("D");
            var d=Console.ReadLine();
            Console.WriteLine("To'g'ri javob");
            var correct=Console.ReadLine();
            var test=new MakeTest(1,subject,savol, a, b, c, d,correct);
        }
        public static void Tuzish()
        {
            Console.WriteLine("Fan nomi");
            string s=Console.ReadLine();
            Console.WriteLine("Talabalar soni");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("testlar");
            int b=int.Parse(Console.ReadLine());
            Write.FaylgaYozish(s,a,b);
        }
    }
}
