using System;

namespace LearningProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bài 1:
                Viet hàm Nhập và Xuất 1 mảng số nguyên
             */

            int[] mang = NhapMangSoNguyen();
            XuatMangSoNguyen(mang);


            Console.ReadLine();
        }

        // Viết hàm nhập, có output là mảng số nguyên, không có input
        static int[] NhapMangSoNguyen()
        {
            int n;
            Console.Write("Vui long nhap so luong phan tu co trong mang: ");
            n = int.Parse(Console.ReadLine()); //4

            int[] mangKetQua = new int[n];
            for(int i = 0;i< mangKetQua.Length; i++) // 0  1 2 3 
            {
                Console.Write($"Vi tri {i} la: ");
                mangKetQua[i] = int.Parse(Console.ReadLine());
            }

            return mangKetQua;
        }

        // Viết hàm xuất, ko có output, input sẽ là 1 mảng số nguyên

        static void XuatMangSoNguyen(int[] mang)
        {
            Console.WriteLine($"Mang nay co {mang.Length} phan tu");
            for (int i = 0; i < mang.Length; i++) // 0  1 2 3 
            {
                Console.WriteLine($"Vi tri {i} la: {mang[i]}");
            }
        }
    }
}
