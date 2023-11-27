using Static_Extension.Interfaces;
using System.Text.RegularExpressions;

namespace Static_Extension.Services
{
    public class User : IAccount
    {
        static int ID { get; set; }
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                    return;
                }

                Console.WriteLine("Please make sure you entered correctly..");
            }
        }
        private string _password { get; set; }
        public User(string email, string password)
        {
            Id = ++ID;
            Email = email;
            Password = password;
        }
        public User()
        {
            Id = ++ID;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"About USER:ID: {Id}, Fullname:{Fullname}, Email:{Email}");
        }

        public bool PasswordChecker(string password)
        {
            return new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])[A-Za-z0-9]{8,64}$").IsMatch(password);
        }
    }
}
