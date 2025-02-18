namespace lambdaExpression_14;

public delegate void Mydelegate(int num);
class Program
{
    static void Main(string[] args)
    {
        Mydelegate obj =(a)=>{
            a+=11;
            System.Console.WriteLine("Using lamda expression value:{0}",a);
        };
        obj.Invoke(9);
    }
}
