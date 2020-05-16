using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static public int MyMin(int[] array)
        {
            if (array == null)
            {
                throw new Exception("空数组异常");
            }
            int value = 10000000;
            foreach (int x in array)
            {
                if (value > x)
                {
                    value = x;
                }
            }
            return value;
        }
        static public int MyMax(int[] array)
        {
            if (array == null)
            {
                throw new Exception("空数组异常");
            }
            int value = -10000000;
            foreach (int x in array)
            {
                if (value < x)
                {
                    value = x;
                }
            }
            return value;
        }
        static public double MyAverage(int[] array)
        {
            if (array == null)
            {
                throw new Exception("空数组异常");
            }
            double Sum = 0;
            double Average = 0;
            foreach (int x in array)
            {
                Sum += x;
            }
            Average = Sum / array.Length;
            return Average;
        }
        static void Main(string[] args)
        {
            int[] my_array = new int[] { 1, 2, 4, 5, 6, 3, 7, -1, 343, 37, 8 };
            Console.WriteLine("最小值是:{0}", my_array.Min());
            Console.WriteLine("最大值是:{0}", my_array.Max());
            Console.WriteLine("平均值是:{0}", my_array.Average());
            int sum = 0;
            foreach (int x in my_array)
            {
                sum += x;
            }
            Console.WriteLine("该数组元素和为:{0}", sum);
            Console.WriteLine("-------以下为自己实现方法-------");
            Console.WriteLine("最小值为:{0}", MyMin(my_array));
            Console.WriteLine("最大值为:{0}", MyMax(my_array));
            Console.WriteLine("平均值为:{0}", MyAverage(my_array));
            Console.ReadKey();
        }
    }
}
