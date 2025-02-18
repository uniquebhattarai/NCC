using System;
namespace Constructor_1
{

class Example
{
    private Example()
    {
        System.Console.WriteLine("Private Constructor Called");
    }

    public static void Display(){
        System.Console.WriteLine("Hello from example class");
    }
}

  class PrivateConstructor
  {
    static void Main(string[] args){
        // Example e1 = new Example(); This will cause compilation error due to protection level
        Example.Display();
    }
  }  
}