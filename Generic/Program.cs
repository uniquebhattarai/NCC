namespace Generic;


public class GenericClass<T>
{
    public T value;

    public GenericClass(T val){
        value=val;
    }

    public T GetValue(){
        return value;
    }

}
class Program
{
    static void Main(string[] args)
    {
        GenericClass<float> obj = new GenericClass<float>(3.69f);
        System.Console.WriteLine("Float value:{0}",obj.GetValue());

        GenericClass<string> obj2 = new GenericClass<string>("Hello its me unique bhattarai");
        System.Console.WriteLine("String value:{0}",obj2.GetValue());
        
    }
}
