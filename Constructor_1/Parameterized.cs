namespace Constructor_1;


class Parameterized
{
    private string Name;
    private string Faculty;
    private int Symbolno;

    public Parameterized(string name,string faculty,int symbolno){
        Name =name;
        Faculty = faculty;
        Symbolno = symbolno;
    }

    public void Display(){
        Console.WriteLine("Name:{0}",Name);
        Console.WriteLine("Faculty:{0}",Faculty);
        Console.WriteLine("SymbolNo:{0}",Symbolno);
    }
    static void Main(string[] args)
    {
        Parameterized p1 = new Parameterized("Unique Bhattarai", "Computer Science",28136);
        p1.Display();
    }
}
