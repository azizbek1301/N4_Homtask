namespace Click
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string defaultCardNumber { get; set; }
        private double defaultCardBalance { get; set; } = 0;
        public User(int id, string firsName, string lastName, string phoneNumber)
        {
            Id = id;
            FirstName = firsName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            string path = @"D:\Dasturlash olami\.Net Muhammad_Abdulloh_Projects\Bootcamp_N7\Click\User.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine($"{id}|{firsName}|{lastName}|{phoneNumber}");
                tw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine($"{id}|{firsName}|{lastName}|{phoneNumber}");
                tw.Close();

            }
        }
    }
}
