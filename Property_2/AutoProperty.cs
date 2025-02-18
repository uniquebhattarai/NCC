using System;
namespace Property_2
{
    class Programmer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class AutoProperty{
        static void Main(string[] args){
            Programmer p1 = new Programmer();
            p1.FirstName = "Unique";
            p1.LastName = "Bhattarai";
            System.Console.WriteLine(p1.FirstName+" "+p1.LastName);
        }
    }
}