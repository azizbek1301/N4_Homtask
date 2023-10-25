Student std = new Student();

Console.Write("qayasi maksimal balni topmoqchisiz ");
int maxpoint = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
var Qiymat=std.GetAllStudents();
var students = (from s in Qiymat
                group s by s.Point into g
                orderby g.Key descending
                select new
                {
                    result = g.ToList()
                }).ToList();


students[maxpoint - 1].result
                .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  Point : {2}", i.Id, i.Name, i.Point));

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Point { get; set; }

    public  List<Student> GetAllStudents()
    {
        var students = new List<Student>();
        students.Add(new Student { Id = 1,  Name= " Joseph ", Point = 800 });
        students.Add(new Student { Id = 2,  Name= "Alex", Point= 458 });
        students.Add(new Student { Id = 3,  Name= "Harris", Point = 900 });
        students.Add(new Student { Id = 4,  Name= "Taylor", Point = 900 });
        students.Add(new Student { Id = 5,  Name= "Smith", Point = 458 });
        students.Add(new Student { Id = 6,  Name= "Natasa", Point = 700 });
        students.Add(new Student { Id = 7,  Name= "David", Point = 750 });
        students.Add(new Student { Id = 8,  Name= "Harry", Point = 700 });
        students.Add(new Student { Id = 9,  Name= "Nicolash", Point = 597 });
        students.Add(new Student { Id = 10, Name = "Jenny", Point = 750 });
        return students;
    }
}