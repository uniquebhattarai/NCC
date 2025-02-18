namespace Delegate_9
{
    public delegate void Calculation(int a , int b);

class Program
{
    public static void Addition(int a , int b){
        int result = a+b;
        System.Console.WriteLine("Addition result is:{0}",result);
    }

    public static void Subtraction(int a , int b){
        int result = a-b;
        System.Console.WriteLine("Subtraction result is:{0}",result);
    }

    public static void Multiply(int a , int b){
        int result = a*b;
        System.Console.WriteLine("Multiply result is:{0}",result);
    }
    static void Main(string[] args)
    {
        Calculation calc = new Calculation(Program.Addition);
        calc.Invoke(20,30);
        calc=Subtraction;
        calc(30,20);
        calc=Multiply;
        calc(13,13);

        System.Console.WriteLine("-------------------");

        System.Console.WriteLine("Multicaste Delegate");
        Calculation obj = new Calculation(Program.Addition);
        obj+=Subtraction;
        obj+=Multiply;
        obj.Invoke(20,10);
    }
}
}