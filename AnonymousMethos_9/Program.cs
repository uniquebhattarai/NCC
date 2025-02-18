namespace AnonymousMethos_9;

public delegate void Mydelegate(int num);
class Program
{
    static void Main(string[] args)
    {
        Mydelegate obj = delegate(int a){
            a+=10;
            System.Console.WriteLine("The number after adding 10 :{0}",a);
        };
        obj.Invoke(5);
    }
}
