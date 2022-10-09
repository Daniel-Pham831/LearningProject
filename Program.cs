using System;

namespace LearningProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo ra KDL mới tên là ConNguoi, sau đó tự định nghĩa những dữ liệu riêng trong đó, xuất ra những dữ liệu đó
            Human hung = new Human("Hung", "Nam", 18);
            Human lan = new Human("Lan", "Nu", 18);
            Human boy = new Human();

            hung.ShowInformation();
            lan.ShowInformation();
            boy.ShowInformation();

            Console.ReadLine(); 
        }


    }
}
