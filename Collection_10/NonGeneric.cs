using System.Collections;
namespace Collection_10;

class NonGeneric
{
    static void Main(string[] args)
    {
        Stack Mystack = new Stack();
        Mystack.Push("Unique");
        Mystack.Push("Liverpool");
        Mystack.Push("RCB");
        Mystack.Push("CSIT");
        Mystack.Push(69);

        foreach(object item in Mystack ){
            System.Console.WriteLine(item);
        }
        
    }
}
