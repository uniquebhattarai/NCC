using System.IO;
using System.Text;
namespace File_12;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the text to write in the file: ");

        string Path = @"/home/uniq/Desktop/UniqueNCCLAB/Unique.txt";
        using (FileStream fs = new FileStream(Path,FileMode.Create,FileAccess.Write)){
            using(StreamWriter writer = new StreamWriter(fs,Encoding.UTF8))
            {
                string input = Console.ReadLine();
                writer.WriteLine(input);
            }
        }
    }
}
