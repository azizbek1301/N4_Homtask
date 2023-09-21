

using TestTuzishProject;

string tanla = "1.test tuzish \n 2.chiqish";
while (true)
{
    Console.WriteLine(tanla);
    int tanlov=int.Parse(Console.ReadLine());
    switch (tanlov)
    {
        case 1:
            NewTest.TestNew();
            break;
        case 2:
            return 0;
            break;
        default:
            Console.WriteLine("xato raqam");
            break;
    }
}