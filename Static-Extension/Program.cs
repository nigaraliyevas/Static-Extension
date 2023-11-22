using Static_Extension.Domain.Models;
using Static_Extension.Services;
#region task-1
/*IAccount(interface):
-PasswordChecker() - parametr olaraq string password qəbul edir.
- ShowInfo()
User class (IAccount-u implement edir)
-Id
- Fullname
- Email
- Password
- PasswordChecker() - PasswordChecker methodu - gələn string password dəyərinin şərtləri ödəyib ödəmədiyini yoxlayıb true/false dəyər qaytarir.                        Şərtlər:
                        -şifrədə minimum 8 character olmalıdır
                        - şifrədə ən az 1 böyük hərf olmalıdır
                        - şifrədə ən az 1 kiçik hərf olmalıdır
                        - şifrədə ən az 1 rəqəm olmalıdır
- ShowInfo() -bu method console-a user-in Id, Fullname və email dəyərlərini yazdırır

ps: Id dəyəri hər dəfə bir user obyekti yaranan zaman avtomatik artmalıdır və qıraqdan 
id dəyərini dəyişmək olmamalıdı ancaq get etmək olar. User yarandığı zaman email və password 
təyin edilməsi məcburidir.User-ə şifrə təyin edilərkən şifrənin PasswordChecker methodunun şərtlərini ödəməsi lazımdır.*/

/*User user1 = new("lorem","555sSjjz");
user1.Fullname = "Lorem Imsum";
//user1.ID = 5;set elemek olmur ✔️
Console.WriteLine(user1.PasswordChecker(user1.Password));
user1.ShowInfo();

User user2 = new("","852sSHJjz");
user2.Fullname = "Filankes Filankesov";
//user2.ID = 6;set elemek olmur ✔️
Console.WriteLine(user2.PasswordChecker(user2.Password));
user2.ShowInfo();*/

/*//===>Solution 2 <=== //
User user3 = new();
user3.Fullname = "Null None";
//user2.ID = 6;set elemek olmur ✔️
Console.WriteLine("Please Enter Email:");
user3.Email = Console.ReadLine();
Console.WriteLine("Please Enter Password:");
user3.Password = Console.ReadLine();
Console.WriteLine(user3.PasswordChecker(user3.Password));
user3.ShowInfo();*/
#endregion
#region task2
/*Student class
-Id
- Fullname
- Point
- StudentInfo() - Student -in bütün məlumatlarını ekrana console-a yazdırır

ps: Id dəyəri hər dəfə bir user obyekti yaranan zaman avtomatik artmalıdır və 
qıraqdan id dəyərini dəyişmək olmamalıdı ancaq get etmək olar. Fullname və point olmadan student obyekti yaratmaq olmaz.*/
Student student1 = new("Doler Sit", 75);
Console.WriteLine(student1.StudentInfo());
Student student2 = new("Lorem Ipsum", 101);
Console.WriteLine(student2.StudentInfo());
#endregion 