using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            int[] test1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] test2 = new int[5] { 6, 7, 8, 9, 10 };
            int[] test3 = new int[5] { 11, 12, 13, 14, 15 };
            int[] test4 = new int[5] { 16, 17, 18, 19, 20 };
            int[] test5 = new int[5] { 21, 22, 23, 24, 25 };
            int[] test6 = new int[5] { 1, 6, 11, 16, 21 };
            int[] test7 = new int[5] { 2, 7, 12, 17, 22 };
            int[] test8 = new int[5] { 3, 8, 12, 18, 23 };
            int[] test9 = new int[5] { 4, 9, 14, 19, 24 };
            int[] test10 = new int[5] { 5, 10, 15, 20, 25 };

            Console.WriteLine("--------------------------------");
            Console.WriteLine(" ! Bingo Game");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Hello! Please enter 5 numbers between 1-25");
            for (int i=0; i < 5; i++)
            {
                
                Console.Write("Input: ");
                int num = Convert.ToInt32(Console.ReadLine());
                number[i] += num;
            }

            Console.Write("Reult : " + number[0] + "," + number[1] + "," + number[2] + "," + number[3] + "," + number[4]);
            Console.ReadLine();

            bool bing = false;

            for(int i=0; i<number.Length-1; i++)
            {
                if(number[i] == test1[i] || number[i] == test2[i] || number[i] == test3[i] || number[i] == test4[i] || number[i] == test5[i] || number[i] == test6[i]
                    || number[i] == test7[i] || number[i] == test8[i] || number[i] == test9[i] || number[i] == test10[i])
                {
                    bing = true;
                }
            }

            if(bing == true)
            {
                Console.WriteLine(" Bingo!!!");
                Console.WriteLine(" Press Enter to exit.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Not Bingo!!!");
                Console.WriteLine(" Press Enter to exit.");
                Console.ReadLine();
            }
        }
    }
}
