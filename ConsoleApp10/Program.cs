using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp10
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 7, 4, 6, 3, 1, 2 };
            Console.WriteLine("Display list in descending order");
            sort(list, greaterThan);
            display(list);
            Console.WriteLine("Display list in ascending order");
            sort(list, lessThan);
            display(list);
        }
        public static void sort(int[] num, Func<int, int, bool> c)
        {
            int i, j;
            bool flag = true; // set flag to 1 to start first pass
            int numLength = num.Length;
            for (i = 1; i <= numLength && flag; i++)
            {
                flag = false;
                for (j = 0; j < (numLength - 1); j++)
                {
                    if (c(num[j + 1], num[j])) // order numbers
                    {
                        int temp = num[j]; // swap elements
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                        flag = true; // indicates that a swap occurred.
                    }
                }
            }
        }//end method
        public static bool greaterThan(int first, int second)
        {
            return first > second;
        }
        public static bool lessThan(int first, int second)
        {
            return first < second;
        }
        public static void display(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }//end
    }
}