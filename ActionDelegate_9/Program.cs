namespace ActionDelegate_9;

class Program
{
    public static void Student(string Name,string Lab,int Rollno){
        System.Console.WriteLine("Lab no:{0}",Lab);
        System.Console.WriteLine("Name:{0}",Name);
        System.Console.WriteLine("Rollno:{0}",Rollno);
    }
    static void Main(string[] args)
    {
        Action<string,string,int> obj = Student;
       obj.Invoke("Unique bhattarai","9d",9);
    }
}
