namespace Structure_8;

struct Student
{ 
    public string Name;
    public int Rollno;

    public Student(string name, int rollno){
        Name = name;
        Rollno = rollno;
    }

    public void Display(){
        Console.WriteLine("Student Name:{0}", Name);
        System.Console.WriteLine("Rollno:{0}", Rollno);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student obj = new Student("Unique Bhattarai",9);
        obj.Display();
    }
}
