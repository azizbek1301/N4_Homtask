
namespace Redular
{

    class GFG
    {
        public static string removeNonAlphanumeric(string str)
        {
       
            str = str.Replace("[^a-zA-Z0-9_.]$", "");

        
            return str;
        }

   
        public static void Main(string[] args)
        {

        
            string str1= "AA@%^&CC";
            Console.WriteLine(removeNonAlphanumeric(str1));

        
            string str2= "Python";
            Console.WriteLine(removeNonAlphanumeric(str2));

       
            string str3= "w3resource.com";
            Console.WriteLine(removeNonAlphanumeric(str3));
        }
    }
}