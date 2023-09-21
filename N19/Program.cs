

// ?? operators - Null-coalescing operator or dereferencing operator



//int? number1=2;
//int number2=2;
//int number3=number1 ?? number2;
//Console.WriteLine(number3);


// Delegatlar

//using System;
//namespace Delegate
//{
//    class Program
//    {
//        // delegat e'lon qilish
//        public delegate void MyDelegate(string msg);

//        public static void Main(string[] args)
//        {
//            // delegat obyektiga metod tayinlash
//            MyDelegate del1 = new MyDelegate(MethodA);

//            // delegat obyektiga metod tayinlash
//            MyDelegate del2 = MethodA;

//            //lambda ifodadan foydalanish
//            MyDelegate del3 = (string msg) => Console.WriteLine(msg);


//            del1.Invoke("Assalomu alaykum");
//            del2("assalom");
//            Console.ReadKey();
//        }

//        //metodni e'lon qilish
//        static void MethodA(string message)
//        {
//            Console.WriteLine(message);
//        }
//    }
//}


//namespace Delegate
//{
//    public delegate void MyDelegate(string msg);

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyDelegate del = ClassA.MethodA;
//            del("Hello World");

//            del = ClassB.MethodB;
//            del("Hello World");

//            del = (string msg) => Console.WriteLine("lambda ifoda ishlatilishi: " + msg);
//            del("Hello World");

//            Console.ReadKey();
//        }
//    }
//    class ClassA
//    {
//        public static void MethodA(string message)
//        {
//            Console.WriteLine("ClassA.MethodA() metodi chaqirildi: " + message);
//        }
//    }
//    class ClassB
//    {
//        public static void MethodB(string message)
//        {
//            Console.WriteLine("ClassB.MethodB() metodi chaqirildi: " + message);
//        }
//    }
//}



// Func Delegate

//namespace Delegates
//{
//    public delegate Tresult Func<in T, out Tresult>(T arg);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //delegatga metod tayinlash
//            Func<int, bool> add = IsOdd;

//            //son kiritish
//            int number = int.Parse(Console.ReadLine());

//            //delegatni ishlatish va natijani o'zlashtirish
//            bool result = add(number);

//            //natijani ekranga chiqarish
//            Console.WriteLine($"{number} soni toqligi: {result}");

//            Console.ReadKey();
//        }

//        //sonni toqlikka tekshiruvchi metod
//        static bool IsOdd(int a)
//        {
//            return a % 2 == 1;
//        }
//    }
//}



//namespace Delegates
//{

//    class Program
//    {

//        public delegate int MyDelegate(int num1, int num2);
//        static void Main(string[] args)
//        {
//            EventExample.InvokeMethods();

//        }
//    }
//    static class EventExample
//    {

//        public static void InvokeMethods()
//        {
//            EventHandlers.MethodA(3, 7);
//            EventHandlers.MethodB(4, 7);


//        }
//    }
//    static class EventHandlers
//    {
//        public static int MethodA(int number1,int number2)
//        {
//            Console.WriteLine("MethodA");
//            return number1+number2;
//        }
//        public static int MethodB(int number1, int number2)
//        {
//            Console.WriteLine("MethodB");
//
//            return number1 + number2;
//        }
//    }
//}
  




// Hodisa tadbiri uchun Event delegate
public delegate void EventHandler();

// Hodisa yaratish uchun sinf

public class EventExample
{
    public event EventHandler myEvent;
    public void InvokeEvent()
    {
        Console.WriteLine("Hodisa chairildi");
        // Hodisa tadbirini boshqarish uchun Event delegatni chaqirish
        myEvent?.Invoke();
    }
}

// Hodisa tadbiri bilan bog'liq metodlar

public class EventHandlers
{
    public void Handler1()
    {
        Console.WriteLine("Handler 1 ishga tushdi");
    }
    public void Handler2()
    {
        Console.WriteLine("Handler 2 ishga tushdi");
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        EventExample eventExample = new EventExample();

        EventHandlers eventHandlers = new EventHandlers();

        eventExample.myEvent += eventHandlers.Handler1;
        eventExample.myEvent += eventHandlers.Handler2;

        eventExample.InvokeEvent();

        eventExample.myEvent-=eventHandlers.Handler2;
        eventExample.InvokeEvent();
    }
}