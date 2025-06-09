namespace HW5Classes
{
    public class StudentProfile
    {
        public string Name { get; private set; }
        public int    Age  { get; private set; }

        public StudentProfile(string name, int age)
        {
            Name = name;
            Age  = age;
        }

        public void UpdateName(string newName) => Name = newName;

        public void UpdateAge(int newAge)
        {
            if (newAge > 0) Age = newAge;
        }

        public void Introduce(string hometown = null)
        {
            if (string.IsNullOrWhiteSpace(hometown))
                Console.WriteLine($"Hi, I'm {Name}. I'm {Age} and I enjoy coding.");
            else
                Console.WriteLine($"Hi, I'm {Name} from {hometown}. I'm {Age} and I enjoy coding.");
        }

        public void ShowProfile()
        {
            Console.WriteLine("Student Profile");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age:  {Age}");
            Console.WriteLine();
        }
    }

    //nicer
    public class UniversityDemo
    {
        public static void Main()
        {
            var chica = new StudentProfile("Chica", 21);
            chica.Introduce("Hawai‘i");
            chica.ShowProfile();

            var noah = new StudentProfile("Noah", 23);
            noah.Introduce();

            noah.UpdateName("Noah K.");
            noah.UpdateAge(24);
            Console.WriteLine("Updated info:");
            noah.ShowProfile();
        }
    }
}