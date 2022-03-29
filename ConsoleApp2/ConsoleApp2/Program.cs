using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gropNo = "D103";
            string fullName = "Ehmed Ehmedov";
            byte age = 18;
            Student student1 = new Student(gropNo, fullName, age);
            student1.GroupNo = gropNo;
            student1.FullName = fullName;
            student1.Age = age;
            Console.WriteLine(student1.ShowInfo());
        }
    }
}
