namespace Indexer_4;

class IntType
{
    class IndexerClass
    {
        private int[] Numbers = new int[5];

        public int this[int index]
        {
            get { return Numbers[index]; }
            set {Numbers[index]=value;  }
        }
    }
    static void Main(string[] args)
    { IndexerClass In = new IndexerClass();
    In[0]=11;
    In[1]=22;
    In[2]=33;
    In[3]=44;
    In[4]=55;

    for(int i=0;i<5;i++){
        System.Console.WriteLine(In[i]);
    }
       
    }
}
