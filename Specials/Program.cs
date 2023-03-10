using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Mb=byte.MaxValue;
            byte mb=byte.MinValue;
            sbyte Msb=sbyte.MaxValue;
            sbyte msb=sbyte.MinValue;
            short Ms=short.MaxValue;
            short ms=short.MinValue;
            ushort Mus=ushort.MaxValue;
            ushort mus=ushort.MinValue;
            int Mi=int.MaxValue;
            int mi=int.MinValue;
            uint Mui=uint.MaxValue;
            uint mui=uint.MinValue;
            long Ml=long.MaxValue;
            long ml=long.MinValue;
            ulong Mul=ulong.MaxValue;
            ulong mul=ulong.MinValue;
            float Mf=float.MaxValue;
            float mf=float.MinValue;
            double Md=double.MaxValue;
            double md=double.MinValue;
            double x=double.PositiveInfinity;
            double y=double.NegativeInfinity;
            double z=double.NaN;
            float fx=float.PositiveInfinity;
            float fy=float.NegativeInfinity;
            float fz=float.NaN;


            Console.WriteLine($"Max value of byte:{Mb}");
            Console.WriteLine($"Min value of byte:{mb}");
            Console.WriteLine($"Max value of sbyte:{Msb}");
            Console.WriteLine($"Min value of sbyte:{msb}");
            Console.WriteLine($"Max value of short:{Ms}");
            Console.WriteLine($"Min value of short:{ms}");
            Console.WriteLine($"Max value of ushort:{Mus}");
            Console.WriteLine($"Min value of ushort:{mus}");
            Console.WriteLine($"Max value of int:{Mi}");
            Console.WriteLine($"Min value of int:{mi}");
            Console.WriteLine($"Max value of uint:{Mui}");
            Console.WriteLine($"Min value of uint:{mui}");
            Console.WriteLine($"Max value of long:{Ml}");
            Console.WriteLine($"Min value of long:{ml}");
            Console.WriteLine($"Max value of ulong:{Mul}");
            Console.WriteLine($"Min value of ulong:{mul}");
            Console.WriteLine($"Max value of float:{Mf}");
            Console.WriteLine($"Min value of float:{mf}");
            Console.WriteLine($"Max value of double:{Md}");
            Console.WriteLine($"Min value of double:{md}");
            Console.WriteLine($"Positive infinity of double: {x}");
            Console.WriteLine($"Negative infinity of double: {y}");
            Console.WriteLine($"Nan of double: {z}");
            Console.WriteLine($"Positive infinity of float: {fx}");
            Console.WriteLine($"Negative infinity of float: {fy}");
            Console.WriteLine($"Nan of float: {fz}");


        }
    }
}
