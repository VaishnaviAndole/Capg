namespace DemoVaishnavi
{
    class Program
    {
        static void Main(string[]args){
 int i,n,sum=0;
      
        Console.WriteLine("input");
                Console.WriteLine("\n");

           n=int.Parse(Console.ReadLine());
        
         for(i=1;i<=n;i++)
         {
         Console.Write("{0}",i);
            sum=sum+i;
         }
                 Console.WriteLine("\n");

        Console.WriteLine(sum);
        
 
     }
    }
}


