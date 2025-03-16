using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace hometask17march
{
    //    internal class Program
    //    {
    //        static void Main()
    //        {
    //            int[] arr = { 4,7,45,32,1,97 };
    //            int minimum=Min(arr);
    //            Console.WriteLine(minimum);
    //        }
    //        static int Min(int[] arr)
    //        {
    //            int min = arr[0];
    //            for (int i = 0; i < arr.Length; i++)
    //            {
    //                if (arr[i] < min)
    //                { min = arr[i]; }
    //            }
    //            return min;
    //        }
    //    }
    //}


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Chevrenin Sahesi" + "=" + Area(2.5));
            Console.WriteLine("Duzbucaqlinin Sahesi" + "=" + Area(5));
            Console.WriteLine("Duzbucaqli Paralepipedin Sahesi" + "=" + Area(5, 1.4, 12));
            Console.WriteLine("Uchbucagin daxiline Chekilmish Cevrenin Sahesi" + "=" + Area(1, 2, 2, 1));
        }
        static double Area(double r)
        {
            double p = 3;
            return p * r * r;
        }
        static double Area(double a, double b)
        { return a * b; }
        static double Area(double a, double b, double c)
        { return 2 * (a * b + a * c + b * c); }
        static double Area(double a, double b, double c, double r)
        {
            double p = (a + b + c) / 2;
            return p * r;
        }
    }
}
















