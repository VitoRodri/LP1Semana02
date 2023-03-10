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

            Console.WriteLine("overflow of byte:"+(byte)(Mb+1));
            Console.WriteLine("underflow of byte:"+(byte)(mb-1));
            Console.WriteLine("overflow of sbyte:"+(sbyte)(Msb+1));
            Console.WriteLine("underflow of sbyte:"+(sbyte)(msb-1));
            Console.WriteLine("overflow of short:"+(short)(Ms+1));
            Console.WriteLine("underflow of short:"+(short)(ms-1));
            Console.WriteLine("overflow of ushort:"+(ushort)(Mus+1));
            Console.WriteLine("underflow of ushort:"+(ushort)(mus-1));
            Console.WriteLine("overflow of int:"+(int)(Mi+1));
            Console.WriteLine("underflow of int:"+(int)(mi-1));
            Console.WriteLine("overflow of uint:"+(uint)(Mui+1));
            Console.WriteLine("underflow of uint:"+(uint)(mui-1));
            Console.WriteLine("overflow of long:"+(long)(Ml+1));
            Console.WriteLine("underflow of long:"+(long)(ml-1));
            Console.WriteLine("overflow of ulong:"+(ulong)(Mul+1));
            Console.WriteLine("underflow of ulong:"+(long)(mul-1));
            Console.WriteLine("overflow of float:");
            Console.WriteLine("underflow of float:");
            Console.WriteLine("overflow of double:");
            Console.WriteLine("underflow of double:");


        }
    }
}
