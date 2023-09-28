

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Thread threadA =new Thread(MethodA);
//        Thread threadB =new Thread(MethodB);
//        Thread threadD =new Thread(MethodC);

//        threadA.Name = "A";
//        threadA.Start();
//        threadB.Name = "B";
//        threadB.Start();
//        threadD.Name = "D";
//        threadD.Start();

//    }

//    public static void MethodA()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine($"My name is {i+1} - A");
//        }
//    }
//    public static void MethodB()
//    {
//        for ( int i = 0;i < 10;i++)
//        {
//            Console.WriteLine($"My name is {i+1} - B");
//        }
//    }
//    public static void MethodC()
//    {
//        for( int i = 0;i<10 ; i++)
//        {
//            Console.WriteLine($"My name is {i + 1} - C");
//        }
//    }
//}

class Program
{


    static async Task Main(string[] args)
    {
        var result = await LongProcess();

        ShortProcess();

        var val = result; // wait untile get the return value

        Console.WriteLine("Result: {0}", val);

        Console.ReadKey();
    }

    static async Task<int> LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");

        return 10;
    }

    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");

        //do something here

        Console.WriteLine("ShortProcess Completed");
    }
}