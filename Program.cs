using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3, }, { 4, 5, 6, }, { 5, 6, 7, } };  

            int sum = 0;
            int multiplication = 1;

            for ( int i = 0; i < numbers.GetLength(0); i++ )
            {
                for ( int j = 0; j < numbers.GetLength(1); j++ )
                {
                    if (i == 1)
                    {
                        sum += numbers[i, j];
                    }
                 
                    if (j == 0)
                    {
                        multiplication *= numbers[j, i];
                    }
                }
            }
       
            Console.WriteLine(" Сумма второй строки - " + sum);
            Console.WriteLine(" Произведение первого столбца - " + multiplication);
        }
    }
}
