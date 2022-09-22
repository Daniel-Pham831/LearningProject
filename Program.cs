

using System;

namespace LearningProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bài 1:
                Viết hàm kiểm tra số nguyên tố
             */

            int num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            bool checker = IsPrimeNumber(num);

            if (checker)
            {
                Console.WriteLine("This is a Prime Number!");
            }
            else
            {
                Console.WriteLine("This is NOT a Prime Number!");
            }

            Console.ReadLine();
        }

        // CHỉ chia hết cho 1 và chính nó
        static bool IsPrimeNumber(int numToCheck)//7
        {
            for(int i =2;i <numToCheck; i++) // 2 3 4 5 6
            {
                if(numToCheck % i == 0) // nếu i chia hết cho numToCheck
                {
                    return false;
                }
            }

            return true;
        }
    }
}
