using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    class Boy : Human
    {
        public int NumberOfCars { get; set; }
        public Boy()
        {
            Sex = "Male";
        }
        public Boy(string name, int age, int num):base("male", name, age)
        {
            NumberOfCars = num;
        }
        public override void Speak()
        {
            Console.WriteLine("*speaking like a boy*");
        }
        public void ToPlayFootball()
        {
            Console.WriteLine("*playing football*");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("number of cars: "+NumberOfCars);
        }
    }
}
