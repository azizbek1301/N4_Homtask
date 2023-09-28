
class ThreadTest
{
    //static void Main()
    //{
    //    Thread t = new Thread(WriteY);
    //    t.Start();

    //    for(int i = 0; i < 500; i++) { Console.Write("x"); }
    //}
    //static void WriteY()
    //{
    //    for (int i = 0; i < 500; i++)
    //    {
    //        Console.Write("y");
    //    }
    //}

  
    static void Main()
    {
        Thread t = new Thread(new ThreadStart(Go));
        t.Start();
        Go();
        
    }
    static void Go()
    {
        Console.WriteLine("Hello");
    }

}   