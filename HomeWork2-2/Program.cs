using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{
    //分解素数
    class Program
    {
        static public void Prime_factor(int num, out int[] factor)
        {
            int[] temp = new int[num];
            int count = 0;
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    temp[count] = i;
                    num /= i;
                    count++;
                }
            }
            factor = new int[count];
            for (int i = 0; i < count; i++)
            {
                factor[i] = temp[i];
            }
        }
        static void Main(string[] args)
        {
            string s;
            int target;
            Console.WriteLine("请输入要分解的数:");
            s = Console.ReadLine();
            target = Int32.Parse(s);
            Console.WriteLine("该数的素数因子是:");
            //for(int i = 2; i*i <= target; i++)
            //{
            //    if(target%i == 0)
            //    {
            //        if(i == 2)
            //        {
            //            Console.WriteLine("2");
            //        }
            //        for(int j = 2; j < i; j++)
            //        {
            //            if(i%j == 0)
            //            {
            //                break;
            //            }
            //            if(j == i-1)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //}
            Prime_factor(target, out int[] factor);
            int Len;
            Len = factor.Length;
            for (int i = 0; i < Len; i++)
            {
                Console.WriteLine(factor[i]);
            }
            Console.ReadKey();
        }
    }
}
