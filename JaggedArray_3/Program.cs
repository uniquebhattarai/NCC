using System.Runtime.CompilerServices;

namespace JaggedArray_3;

class Program
{
    static void Main(string[] args)
    {
        
    string[][] Csit = new string[3][] {
        new string[] { "NCC", "Compiler Design","E-commerce","E-governance","SE","Technical writing"},
        new string[] { "Microprocessor", "c++"},
        new string[] { "ImageProcessing", "DAA","Toc"}
    };
        for (int i = 0;i< Csit.Length;i++){
            for (int j = 0;j<Csit[i].Length;j++){
                System.Console.Write(Csit[i][j]+" ");
            }
            System.Console.WriteLine();
        }
    }
}
