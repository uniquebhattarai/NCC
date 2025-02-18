namespace partialClass_8;

class Program
{
    static void Main(string[] args)
    {
        StudentPartial obj = new StudentPartial();
        obj.FirstName = "Unique";
        obj.LastName = "Bhattarai";
        System.Console.WriteLine("my Name is:{0}",obj.GetCompleteName());
    }
}
