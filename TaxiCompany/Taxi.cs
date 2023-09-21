using System.Security.Cryptography.X509Certificates;

namespace Taksi_Kompaniyasi
{
    public class Taxi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get ; set; }

        public Taxi(int id)
        {
            Id = id;
            
        }

        public string toString(string name, string number)
        {
            return $"{number} raqamli {name} ";
        }
    }
}
