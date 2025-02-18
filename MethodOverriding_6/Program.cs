namespace MethodOverriding_6;

class Parent{
    public virtual void print(){
        Console.WriteLine("This is the method of PARENT class");
    }
}

class Child:Parent
{
    public override void print(){
        System.Console.WriteLine("This is the method of CHILD class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c = new Child();
        c.print();
        
    }
}
