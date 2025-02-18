namespace Property_2;

class Cricketer
{
    string Name{get;} = "Virat Kholi";
    string Club{get;} = "RCB";

    public void Display(){
        System.Console.WriteLine("Name:{0}",Name);
        System.Console.WriteLine("Club:{0}",Club);
    }
}
class ReadOnlyProperty
{
    static void Main(string[] args)
    {
        Cricketer c1 = new Cricketer();
        c1.Display();
    }
}
