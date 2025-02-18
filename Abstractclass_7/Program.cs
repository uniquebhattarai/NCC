using System;
namespace Abstractclass_7
{
    abstract class Person{
        public string Name;
        public int Age;
        public long PhoneNumber;
        public abstract void PrintDetails();
    }

    class Student: Person
    {
        public int Rollno;
        public string Faculty;
        public override void PrintDetails(){
            System.Console.WriteLine("Student Name:{0}",this.Name);
            System.Console.WriteLine("Age:{0}",this.Age);
            System.Console.WriteLine("PhoneNumber:{0}",this.PhoneNumber);
            System.Console.WriteLine("Rollno:{0}",this.Rollno);
            System.Console.WriteLine("Faculty:{0}",this.Faculty);
        }
    }
    class Tecaher: Person
    {
        public string Qualification;
        public override void PrintDetails(){
            System.Console.WriteLine("Teacher Name:{0}",this.Name);
            System.Console.WriteLine("Age:{0}",this.Age);
            System.Console.WriteLine("PhoneNumber:{0}",this.PhoneNumber);
            System.Console.WriteLine("Qualification:{0}",this.Qualification);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Unique Bhattarai";
            s1.Age = 21;
            s1.PhoneNumber=9876543210;
            s1.Rollno=9;
            s1.Faculty="Computer Science";
            s1.PrintDetails();
            System.Console.WriteLine("--------------------------------------------------------");
            Tecaher T1 = new Tecaher();
            T1.Name = "Leslie Lamport";
            T1.Age = 70;
            T1.PhoneNumber=9876545489;
            T1.Qualification="PHD in Computer Science";
            T1.PrintDetails();



        }
    }
}
