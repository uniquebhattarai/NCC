using System;
namespace Base_Class_5
{
    class BaseClass
    {
        public string Name;
        public int Age;

        public BaseClass(string name, int age){
            Name = name;
            Age = age;
            System.Console.WriteLine("Base Class Constructor called");
            System.Console.WriteLine("Name:{0}",Name);
            System.Console.WriteLine("Age:{0}",Age);
        }
    }

    class DerivedClass:BaseClass
    {
        public string Job;
        public DerivedClass(string name,int age,string job):base(name,age){
            Job = job;
            System.Console.WriteLine("Derived Class Constructor called");
        }

        public void ShowDetails(){
            System.Console.WriteLine("Nmae:{0} Age:{1} Job:{2}",Name,Age,Job);
        }

        }
    class Program1
    {
        static void Main(string[] args){
            DerivedClass d1 = new DerivedClass("Unique Bhattarai",21,"Programmer");
            d1.ShowDetails();
        }
    }
}