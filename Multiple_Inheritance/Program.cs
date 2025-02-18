namespace Multiple_Inheritance;

class A{
    public void Show1(){
        System.Console.WriteLine("Method of class A");
    }
}
interface B{
    void Show2();
}

class C:A,B
{
    public void Show2(){
        System.Console.WriteLine("Method of class B interface");
    }
}
class Program
{
    static void Main(string[] args)
    {
        C c1 = new C();
        c1.Show2();
        c1.Show1();
    }
}
