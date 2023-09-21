using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTuzishProject
{
    public class MakeTest
    {
        public int Id { get; set; }
        public string Subject {  get; set; }
        public string Test {  get; set; }
        public string OptionA {  get; set; }
        public string OptionB { get; set; }
        public string OptionC {  get; set; }
        public string OptionD { get; set; }

        public string Togri {  get; set; }
        public MakeTest(int id,string subject,string test,string a,string b, string c, string d,string togri)
        {
            Id = id;
            Subject = subject;
            Test = test;
            OptionA = a;
            OptionB = b;
            OptionC = c;
            OptionD = d;
            Togri = togri;            
        }

    }
}
