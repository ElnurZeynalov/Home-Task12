using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string groupNo;
            string fullName;
            byte age;

            do
            {
                Console.Write("Qrup Nomresi: ");
                 groupNo = Console.ReadLine();
                if(!groupNo.GroupNoChecker())
                    Console.WriteLine("qrup nomresi 1 boyuk herf ve 3 reqemden ibaret olmelidir!");
            } while (!groupNo.GroupNoChecker());
            do
            {
                Console.Write("Ad Soyad: ");
                fullName = Console.ReadLine();
                if (!fullName.FullNameChecker())
                    Console.WriteLine("Numune: Ehmed Ehmedov");
            } while (!fullName.FullNameChecker());
            do
            {
                Console.Write("Yas: ");
                age =Convert.ToByte(Console.ReadLine());
                if (age<5)
                    Console.WriteLine("Yas 5 den boyuk olmalidir");
            } while (age<5);

            Student student1 = new Student(groupNo, fullName, age);
            student1.GroupNo = groupNo;
            student1.FullName = fullName;
            student1.Age = age;
            Console.WriteLine(student1.ShowInfo());
        }
    }
}
