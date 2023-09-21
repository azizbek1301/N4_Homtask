


using System.Text.RegularExpressions;

namespace RegularExpression
{
    
    public static class CheckRegister
    {
        
        
        public static bool CheckAge(string age)
        {
            if (Convert.ToInt32(age) > 0)
            {
                return true;
            }
            return false;
        }

        public static bool CheckEmail(string email)
        {
            Regex EmailCheck = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

            if (EmailCheck.IsMatch(email))
                return true;
            else
                return false;
        }

        public static bool CheckPassword(string password)
        {
            var input = password;
            

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
               return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool PhoneNumberCheck(string phoneNumber)
        {
            Regex phoneCheck = new Regex(@"^9[012345789][0-9]{7}$");
            if (phoneCheck.IsMatch(phoneNumber))
            {
                return true;
            }
            return false;
        }
        
    }
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine(CheckRegister.CheckAge("25"));
            Console.WriteLine(CheckRegister.PhoneNumberCheck("937303376"));
            Console.WriteLine(CheckRegister.CheckEmail("azizbek@gmail.com"));
            Console.WriteLine(CheckRegister.CheckPassword("Azizbek@7"));
        }
    }
}
