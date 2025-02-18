using System;
using System.Linq;
namespace lambdaExpression_14
{
    class LINQ
    {
        static void Main(string[] args){
            int[] num = {5,10,12,17,25,32,42,50};

            var a = num.Where(x => x > 15).OrderByDescending(x => x);
            System.Console.WriteLine("Numbers greater than 15 by Descending Order: ");
            foreach(var item in a){
                Console.WriteLine(item);
            }
        }
    }
}