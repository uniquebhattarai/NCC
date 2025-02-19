namespace Attribute_16;

class Program
{
     [Obsolete("Don't use OldMethod, use NewMethod instead", false)]

      static void OldMethod()
    {
        Console.WriteLine("It is the old method");
    }

    static void NewMethod()
    {
        Console.WriteLine("It is the new method");
    }
    static void Main(string[] args)
    {
        OldMethod();
    }
}
