using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    
    class Program
    {
        static public void Prime_factor(int num)
        {
            int[] array = new int[num + 1];
            for (int i = 2; i * i <= num; i++)
            {
                for (int j = 2; i * j <= num; j++)
                {
                    array[i * j] = 1;
                }
            }
            for (int i = 2; i <= num; i++)
            {
                if (array[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            string s;
            int target;
            Console.WriteLine("请输入要分解的数:");
            s = Console.ReadLine();
            target = Int32.Parse(s);
            int[] my_array = new int[target];
            for (int i = 0; i < target; i++)
            {
                my_array[i] = i + 1;
            }
            my_array[0] = 0;
            for (int i = 0; i < target - 1; i++)
            {
                for (int j = i + 1; j < target; j++)
                {
                    if ((my_array[i] != 0 && my_array[j] != 0) && (my_array[j] % my_array[i] == 0))
                    {
                        my_array[j] = 0;
                        //if(my_array[j]%my_array[i]==0)
                        //{
                        //    my_array[j] = 0;
                        //}
                    }
                }
            }
            Console.WriteLine("{0}以内的素数是:", target);
            for (int i = 0; i < target; i++)
            {
                if (my_array[i] != 0)
                {
                    Console.WriteLine(my_array[i]);
                }
            }
            Prime_factor(target);
            Console.ReadKey();
        }
    }
}
