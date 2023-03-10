using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=Int32.Parse(args[0]);
            char a=char.Parse(args[1]);
            

            for (int i=1; i<=x;i++)
            {
                string chara = new String(a,i);
                Console.WriteLine(chara);

            }
        }
    }
}
