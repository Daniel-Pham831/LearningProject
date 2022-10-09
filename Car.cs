using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    internal class Car
    {
        public Car(string brand,int price,string color)
        {
            this.brand = brand;
            this.price = price;
            this.color = color;
        }

        public Car()
        {
            brand = "None";
            price = 0;
            color = "None";
        }

        //Fields
        public string brand;
        public int price;
        public string color;


        //Methods
        public void Information()
        {
            Console.WriteLine(brand);
            Console.WriteLine(price);
            Console.WriteLine(color);
        }
    }
}
