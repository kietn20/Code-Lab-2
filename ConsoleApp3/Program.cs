using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    public class One
    {
        // public delegate void callingDelegate(int j);
        public static void generateNumbers(Action<int> cd)
        {
            Random rn = new Random();
            int i = 0;
            int j = 0;
            while (i < 10)
            {
                j = rn.Next(9999);
                cd(j);
                i++;
            }
        }
    }

    internal class Program
    {
        One on = new One();
        static void Main(string[] args)
        {
            Action<int> actionDelegate = callDelegate;
            One.generateNumbers(actionDelegate);
            Console.ReadLine();
        }
        public static void callDelegate(int j)
        {
            Console.WriteLine("The current random number is :" + j);
        }
    }
}
