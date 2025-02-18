namespace ExceptionHandling_15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        int num2 = int.Parse(Console.ReadLine());
        try
        {
            int result = num1/num2;
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        finally{
            System.Console.WriteLine("Finally block exectued");
        }

    }
}
