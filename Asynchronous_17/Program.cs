using System.Threading;
using System.Threading.Tasks;
namespace Asynchronous_17;

class Program
{
    public static async void Task1(){
       await Task.Run(() => {
         System.Console.WriteLine("Task 1 Started ...");
        Thread.Sleep(4000);
        System.Console.WriteLine("Task 1 Completed");
        });
       
    }
     public static async void Task2(){
       await Task.Run(() => {
         System.Console.WriteLine("Task 2 Started ...");
        Thread.Sleep(3000);
        System.Console.WriteLine("Task 2 Completed");
        });
       
    }
 public static async void Task3(){
       await Task.Run(() => {
         System.Console.WriteLine("Task 3 Started ...");
        Thread.Sleep(5000);
        System.Console.WriteLine("Task 3 Completed");
        });
       
    }
    public static async void Task4(){
       await Task.Run(() => {
         System.Console.WriteLine("Task 4 Started ...");
        Thread.Sleep(1000);
        System.Console.WriteLine("Task 4 Completed");
        });
       
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Tasks...");
        Task1();
        Task2();
        Task3();
        Task4();

        Thread.Sleep(6000);
         Console.WriteLine("All Tasks Completed.");
        
    }
}
