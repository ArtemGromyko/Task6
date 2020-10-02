using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    abstract class Human
    {
        public string Sex { get; protected set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Human() { }
        public Human(string s, string n, int a)
        {
            Sex = s;
            Name = n;
            Age = a;
        }
        public abstract void Speak();
        public void Move()
        {
            Console.WriteLine("*Moving*");
        }
        public void Eat()
        {
            Console.WriteLine("*Eating*");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Sex: "+Sex+"\nName: "+Name+"\nAge: "+Age);
        }
    }
}
