namespace Interfaces_7;

interface IAnimal
{
    void MakeSound();
}

class Dog:IAnimal
{
    public void MakeSound(){
        System.Console.WriteLine("Dog Barks:woof! woof!");
    }
}

class Cat:IAnimal
{
    public void MakeSound(){
        System.Console.WriteLine("Cat meows: Meow! Meow!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IAnimal animal1 = new Dog();
        animal1.MakeSound();
        IAnimal animal2 = new Cat();
        animal2.MakeSound();
        
    }
}
