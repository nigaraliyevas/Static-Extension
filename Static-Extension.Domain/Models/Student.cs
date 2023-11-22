namespace Static_Extension.Domain.Models
{
    public class Student
    {
        public static int ID { get; set; }
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Point { get; set; }
        public string StudentName { get; set; }

        public Student(string fullname, int point)
        {
            Id = ++ID;
            Fullname = fullname;
            Point = point;
        }
        public string StudentInfo()
        {
            if (Point < 0 || Point > 100)
            {
                return $"Student ID:{Id}:{Fullname}'s point can't be {Point}";
            }
            return $"Student ID {Id}, Student name :{Fullname} Student Point :{Point}";
        }
    }
}
