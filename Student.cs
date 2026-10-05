namespace InheritanceExample
{
    public class Student : User // Student ärver från och alla dess egenskaper
    {
        public List<string> grades { get; set; }

        public Student(string name, string email, string role, List<string> grades)
        {
            Name = name;
            Email = email;
            Role = role;
            this.grades = grades;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Roll: {Role}");

            foreach (string grade in grades)
            {
                Console.WriteLine($"Betyg: {grade}");
            }

            
        }
    }
}
