namespace Constructor_1;

class Person
{
     private string Name;
     private int Rollno; 

    public Person()//parameterless constructor
    {
        Name = "Unique Bhattarai";
        Rollno=9;
    }

    public void Display(){
        Console.WriteLine("Name:{0}",Name);
        Console.WriteLine("Rollno:{0}",Rollno);
    }
}
class Parameterless
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Display();
        
    }
}
