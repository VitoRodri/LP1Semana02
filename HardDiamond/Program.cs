using System;

namespace HardDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=Int32.Parse(args[0]);
            float y=x%2;
            int m=x/2+1;
            int n=2;
            if (y==0)
            {
                Console.WriteLine("I only want odd numbers!");
                
            }
            else if (y!=0)
            {

                for (int i=1; i<=x;i=i+2)
                {
                    
                    string space = new String(' ',m);
                    string chara= new String('.',i);
                    Console.WriteLine(space+chara);
                    m=m-1; 
                    if (i==x)
                    {
                        for (int b=x-2;b>0;b=b-2)
                        {
                            
                            string spaceb = new String(' ',n);
                            string charac= new String('.',b);
                            Console.WriteLine(spaceb+charac);
                            n=n+1;   
                        }
                    } 
                }
               
                
                

            }
        }
    }
}
