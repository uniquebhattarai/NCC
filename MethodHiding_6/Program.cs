namespace MethodHiding_6;

class Parent
{
    public void Show(){
        System.Console.WriteLine("Parent class Method");
    }
}
class Child: Parent
{
    public new void Show(){
        System.Console.WriteLine("Child Class Method");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c = new Child();  
        c.Show();   
    }
}
