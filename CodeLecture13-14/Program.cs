using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLecture13_14
{

    class ArrayUtils
    {
        public static int ShowArray<T>(T[] array)
        {
            Console.WriteLine("Вызван метод ShowArray()");
            return 1;
        }

        public static int ShowMax(int[] array)
        {
            Console.WriteLine("Вызван метод ShowMax()");
            return 2;
        }

        public static int ShowMin(int[] array)
        {
            Console.WriteLine("Вызван метод ShowMin()");
            return 3;
        }

        public static int NormalizeArray(int[] array)
        {
            Console.WriteLine("Вызван метод Normalize()");
            return 4;
        }

        public static int AVG(int[] array)
        {
            Console.WriteLine("Вызван метод AVG()");
            return 5;
        }
        public override string ToString()
        {
            return "Метод класса " + 1;
        }
 
    }

    
    class Program
    {
        public static void Foo(int a)
        {

        }

        delegate int DelegateTools(int[] arr);
        static void Main(string[] args)
        { 
            int[] array = {-2, 34, 55, 0, -12, 234, 3, -2, -100, 6, 0, 345, 322, 122 };
            DelegateTools delegate1;
            DelegateTools delegate2;
            //delegate1 = ArrayUtils.ShowArray;
            //delegate1 += ArrayUtils.ShowMin;
            //delegate1 += ArrayUtils.ShowMax;
            //delegate1 += ArrayUtils.NormalizeArray;
            //delegate1 += ArrayUtils.AVG;

            //delegate1(array);
            //Console.WriteLine();
            //delegate1 -= ArrayUtils.AVG;

            //delegate1 = ArrayUtils.NormalizeArray;
            //delegate1 += ArrayUtils.AVG;
            //delegate2 = ArrayUtils.AVG;
            //delegate2 += ArrayUtils.NormalizeArray;
            //delegate2 += ArrayUtils.NormalizeArray;
            //Console.WriteLine(delegate1==delegate2);

            //delegate1 = ArrayUtils.NormalizeArray;
            //delegate1 += ArrayUtils.AVG;
            //Console.WriteLine(delegate1);


        }
    }
}
