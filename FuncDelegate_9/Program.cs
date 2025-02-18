namespace FuncDelegate_9;

class Program
{
    public static int Add(int a, int b, int c){
        return a + b + c;
    }

    static void Main(string[] args)
    {
        Func<int,int,int,int> f1 =Add;
        int result = f1.Invoke(10,20,30);
        System.Console.WriteLine("Addition Result:{0}",result);

    }
}
