using System.Runtime.InteropServices;
using System.Text.Json;

namespace QuizBot;

public class Test
{
    public string Question { get; set; }
    public string A { get; set; }
    public string B { get; set; }
    public string C { get; set; }
    public string D { get; set; }
    public string CorrectAnswer { get; set; }
}

public static class Testlar
{
    public static List<Test>GetTests()
    {
        var stringTest = File.ReadAllText("D:\\Dasturlash olami\\.Net Muhammad_Abdulloh_Projects\\Bootcamp_N7\\QuizBot\\testlar.json");
        var tests = JsonSerializer.Deserialize<List<Test>>(stringTest);
        return tests;
    }
}

