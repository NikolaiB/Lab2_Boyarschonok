using System.Globalization;
using System.Linq.Expressions;

namespace Lab2_Boyarschonok
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[,] nums = new int[10, 10] 
            { 
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78,  },
                { 0, 1, 2, 10, 20, 30, 40, 50, 60, 78, },
            };

            

          

            //static void GetArifm(int[,] nums)
            //{
            double arifm = 0;
                
                Console.WriteLine("Output array");

                for (int i = 0; i < nums.GetLength(0); i++)
                {

                    for (int k = 0; k < nums.GetLength(1); k++)
                    {
                        Console.Write(nums[i, k] + "\t");
                        arifm += nums[i, k];

                    }
                    Console.WriteLine();
                }


                Console.WriteLine("Арифмитическое = " + "\t" + arifm / nums.Length);

           // }

          

         



        }
    }
}