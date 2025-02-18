using System;

namespace Base_Class_5
{
    class Baseclass{
        public void Display(){
            System.Console.WriteLine("This is the method from base class");
        }
    }

    class Derivedclass:Baseclass
    {
        public new void Display(){
            System.Console.WriteLine("This is a method from the Derived Class");
        }

        public void CallBaseMethod(){
            base.Display();
        }

    }
    class Method
    {
        
        static void Main(string[] args){
            Derivedclass d1 = new Derivedclass();
            d1.CallBaseMethod();
        }
    }
}