using System.Collections.Generic;
namespace Collection_10
{
    class Generic
    {
        static void Main(string[] args){
            Dictionary<string,string> MyDic = new Dictionary<string,string>();
            MyDic.Add("Liverpool","English Football Club");
            MyDic.Add("RCB","Royal Challangers Banglore");
            MyDic.Add("Unique","Programmer");
            foreach(KeyValuePair<string,string> item in MyDic){
                System.Console.WriteLine("{0}:{1}",item.Key,item.Value);
            }
        }
    }
}