using System;
namespace Indexer_4
{
    class StringIndexer{
        class People{
            private string[] Names = new string[3];

            public string this[int i]
            {
                get { return Names[i]; }
                set { Names[i]=value; }
            }

        }
        static void Main(string[] args){
            People p1 = new People();
            p1[0]="Steven Gerrad";
            p1[1]="Mohamad salah";
            p1[2]="Luiz suarez";

            for(int i=0;i<3;i++){
                System.Console.WriteLine(p1[i]);
            }
        }
    }
}