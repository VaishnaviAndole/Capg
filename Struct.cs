
    namespace DemoVaishnavi
{
    class IndexerCreation
    {
        private string[] val=new string[3];
        public string this[int index]
        {
            get{
                return val[index];
            }
            set{
                val[index]=value;
            }
        }
    }
    class Indexersinc
    {
        public static void Main()
        {
            IndexerCreation ic=new IndexerCreation();
            ic[0] = "JAVA";
            ic[1] = "C#";
            ic[2] = "PYTHON";
            Console.WriteLine("First Value={0}",ic[0]);
            Console.WriteLine("Second Value={0}",ic[1]);
            Console.WriteLine("Third Value={0}",ic[2]);
        }
    }
}