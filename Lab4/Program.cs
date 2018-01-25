using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer;
            int temp = 0;
            
            do
            {
                Console.WriteLine("Integer from 1 to 10");
                int Integer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Multiply(Integer));

                Console.WriteLine("Do you want to continue?");
                Answer = Console.ReadLine();
                temp = String.Compare(Answer, "y", true);


            } while(temp == 0);
        }

         public static long Multiply(int Integer)
        {
            long Accumulator = Integer;
            for (int i = 1; i < Integer; i++)
            {
                Accumulator *= i;
                //return Accumulator;
            }
            return Accumulator;
        }

    }
}
