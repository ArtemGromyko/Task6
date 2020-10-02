using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Girl g = new Girl("Dasha", 12, 5);
            g.ShowInfo();
            Console.WriteLine();
            Boy b = new Boy("Tom", 9, 4);
            b.ShowInfo();
        }
    }
}
