namespace Base_Class_5;

class Base{
    public string Country = "Soviet Union";
}

class Derived:Base
{
    public new string Country = "Russia";
    public void ShowCountry(){
        System.Console.WriteLine("Base class Country:{0}",base.Country);
        System.Console.WriteLine("Derived class Country:{0}",Country);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Derived d = new Derived();
        d.ShowCountry();
        
    }
}
