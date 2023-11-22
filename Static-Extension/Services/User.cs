using Static_Extension.Interfaces;
using System.Text.RegularExpressions;

namespace Static_Extension.Services
{
    public class User:IAccount
    {
        static int ID { get; set; }
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email,string password)
        {
            Id= ++ID;
            Email= email;
            Password= password;
        }
        public User()
        {
            Id = ++ID;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"About USER:ID: {Id}, Fullname:{Fullname}, Email:{Email}");
        }

        public string PasswordChecker(string password)
        {
            Password = password;
            bool pattern =Regex.IsMatch(Password,@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])[A-Za-z0-9]{8,64}$");
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password)) 
                return $"Email Or Password is Empty.";
            if (pattern)
                return $"Successfully entered";
            return $"Please enter right";
        }
    }
}
