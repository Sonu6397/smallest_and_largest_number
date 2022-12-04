using System;

namespace smallest_and_largest_number
{
    class Program
    {
        static void Main(string[] args)
        {


            //int a = 10, b = 25;
            //Console.WriteLine("value of a ="+ a);
            //Console.WriteLine("value of b="+ b);
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine("new value of a="+ a);
            //Console.WriteLine("new value of b="+ b);
            //Console.ReadLine();
            //int[] arr = new int[5];
            //int max, min;
            //Console.WriteLine("enter array element");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("element {0} - ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //max = arr[0];
            //min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine("maxmum number from an array is {0}", max);
            //Console.WriteLine("minimum number from an array is {0}", min);
            //Console.ReadLine();

            string str = "";
            Console.WriteLine("enter a string ");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str_resverse = new string(arr);

            if (str.Equals(str_resverse))
            {
                Console.WriteLine("pallindrom string");
            }
            else
            {
                Console.WriteLine("not pallindrom string");
            }
            Console.ReadLine();

        }
    }
}
