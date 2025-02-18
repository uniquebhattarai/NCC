using System.Runtime.CompilerServices;

namespace enum_8;

enum Week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a day of the week");
        string UserInput = Console.ReadLine().Trim();

        if(Enum.TryParse(UserInput, true,out Week day)){
            if(day == Week.Saturday){
                Console.WriteLine("{0} is a Holiday",day);
            }
            else if(day==Week.Friday){
                Console.WriteLine("{0} is a WeekEnd",day);
            }else{
                System.Console.WriteLine("{0} is a WeekDay",day);
            }
        }else{
             Console.WriteLine("Invalid input. Please enter a valid day (e.g., Monday, Tuesday, etc.)");
        }
    }
}
