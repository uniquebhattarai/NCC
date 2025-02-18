using System;
namespace Constructor_1
{

class StaticConstructor{

    static int Count;

    public StaticConstructor(){
        System.Console.WriteLine("Instance constructor is called");
        Count++;
    }
    static StaticConstructor(){
        System.Console.WriteLine("Static Constructor is called");
        Count=19;
    }
    public void Display(){
        System.Console.WriteLine("Value of Count:{0}",Count);
    }

    static void Main(string[] args){
        StaticConstructor s1 = new StaticConstructor();
        System.Console.WriteLine("Main method");
        s1.Display();


    }
}
}