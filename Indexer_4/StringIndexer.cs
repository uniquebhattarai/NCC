using System;
namespace Indexer_4
{
    class StringIndexer{
        class People{
           private Dictionary<string, string> names = new Dictionary<string, string>();

        public string this[string key] // String-based indexer
        {
            get 
            {
                return names.ContainsKey(key) ? names[key] : "Not Found";
            }
            set { names[key] = value; }
        }

        }
        static void Main(string[] args){
            People p1 = new People();
             p1["Captain"] = "Steven Gerrard";
           p1["Winger"] = "Mohamed Salah";
           p1["Striker"] = "Luis Suárez";

            Console.WriteLine( p1["Captain"]);
            Console.WriteLine( p1["Winger"]);
            Console.WriteLine( p1["Striker"]);
            
            System.Console.WriteLine("\nLab No:4");
        System.Console.WriteLine("Name:Unique Bhattarai");
        System.Console.WriteLine("RollNo:9");
       
        }
        
    }
}