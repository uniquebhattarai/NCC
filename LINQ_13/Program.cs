namespace LINQ_13;

class Program
{
    static void Main(string[] args)
    {
        
        int[] age ={10,20,22,30,40,50,22,33,9,8,56,7};

        var a = from i in age where i>20 orderby i select i;

        foreach(int item in a){
            System.Console.WriteLine(item);
    }
}
}
