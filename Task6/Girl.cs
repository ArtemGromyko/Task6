using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    class Girl : Human
    {
        public int NumberOfDolls { get; set; }
        public Girl()
        {
            Sex = "Female";
        }
        public Girl(string name, int age, int num):base("Female", name, age)
        {
            NumberOfDolls = num;
        }
        public override void Speak()
        {
            Console.WriteLine("*speaking like a girl*");
        }
        public void ToDance()
        {
            Console.WriteLine("*dancing*");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("number of dolls: "+NumberOfDolls);
        }
    }
}
