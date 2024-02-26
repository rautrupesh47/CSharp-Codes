using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Datatypes
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            bool b1 = true;
            Console.WriteLine(b1);
            Console.WriteLine( sizeof (bool));
            

            byte i1 = 10;
            Console.WriteLine(i1);
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            short i2 = 10;
            Console.WriteLine($"{i2}:{sizeof(short)}: {short.MinValue} : {short.MaxValue}");


            short i3 = 10;
            Console.WriteLine($"{i3}:{sizeof(int)}: {int.MinValue} : {int.MaxValue}");


            short i4 = 10;
            Console.WriteLine($"{i4}:{sizeof(long)}: {long.MinValue} : {long.MaxValue}");

            float f1 = 10.5f;
            Console.WriteLine($"{f1}:{sizeof(float)}: {float.MinValue} : {float.MaxValue}");


            double f2 = 10.5;
            Console.WriteLine($"{f2}:{sizeof(double)}: {double.MinValue} : {double.MaxValue}");

            decimal f3 = 10.5m;
            Console.WriteLine($"{f3}:{sizeof(decimal)}: {decimal.MinValue} : {decimal.MaxValue}");

            Console.ReadLine();

        }
    }
}
