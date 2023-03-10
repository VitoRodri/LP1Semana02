using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg=args[0];
            int x;
            bool Parsabel = Int32.TryParse(arg,out x);
            if (Parsabel)
            {
                x++;
                Console.WriteLine(x);
                x--;
                x--;
                Console.WriteLine(x);
            }
        }
    }
}
