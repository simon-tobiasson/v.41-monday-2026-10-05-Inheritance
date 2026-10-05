namespace InheritanceExample
{
    public class Teacher : User // Teacher ärver från User och alla dess egenskaper
    {
        public string Faculty { get; set; }

        public Teacher(string name, string email, string role, string faculty)
        {
            Name = name;
            Email = email;
            Role = role;
            Faculty = faculty;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Roll: {Role}");
            Console.WriteLine($"Fakultet: {Faculty}");
        }
    }
}
