using System;
namespace ExceptionHandling_15
{
    class Throw
    {
        static void Main(string[] args){
            System.Console.WriteLine("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());
            try{
                if(age>=18){
                    System.Console.WriteLine("You are Eligible to vote....");
                }
                else{
                    throw new Exception("You are not Eligible to vote...");
                }

            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}