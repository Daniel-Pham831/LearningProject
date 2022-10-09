using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    internal class Human
    {
        public Human()
        {
            name = "NoName";
            gender = "None";
            age = 0;
        }

        public Human(string n, string g, int a)
        {
            name = n;
            gender = g;
            age = a;
        }


        public string name;
        public string gender;
        public int age;

        public void ShowInformation()
        {
            Console.WriteLine($"My name is: {name}");
            Console.WriteLine($"My gender is: {gender}");
            Console.WriteLine($"My age is: {age}");
        }
    }
}
