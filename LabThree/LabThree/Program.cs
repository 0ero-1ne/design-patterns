using Lec03LibN;
using System;

namespace LabThree
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lab 3 - Abstract factory");

            IFactory L1 = Lec03BLib.getL1();

            Employee employee1 = new(L1.getA(25));
            Console.WriteLine(string.Format("Bonus-L1-A = {0}", employee1.calcBonus(4)));

            Employee employee2 = new(L1.getB(25, 1.1f));
            Console.WriteLine(string.Format("Bonus-L1-B = {0}", employee2.calcBonus(4)));

            Employee employee3 = new(L1.getC(25, 1.1f, 5.0f));
            Console.WriteLine(string.Format("Bonus-L1-C = {0}", employee3.calcBonus(4)));

            IFactory L2 = Lec03BLib.getL2(1);

            Employee employee4 = new(L2.getA(25));
            Console.WriteLine(string.Format("Bonus-L2-A = {0}", employee4.calcBonus(4)));

            Employee employee5 = new(L2.getB(25, 1.1f));
            Console.WriteLine(string.Format("Bonus-L2-B = {0}", employee5.calcBonus(4)));

            Employee employee6 = new(L2.getC(25, 1.1f, 5.0f));
            Console.WriteLine(string.Format("Bonus-L2-C = {0}", employee6.calcBonus(4)));

            IFactory L3 = Lec03BLib.getL3(1, 0.5f);

            Employee employee7 = new(L3.getA(25));
            Console.WriteLine(string.Format("Bonus-L3-A = {0}", employee7.calcBonus(4)));

            Employee employee8 = new(L3.getB(25, 1.1f));
            Console.WriteLine(string.Format("Bonus-L3-B = {0}", employee8.calcBonus(4)));

            Employee employee9 = new(L2.getC(25, 1.1f, 0.5f));
            Console.WriteLine(string.Format("Bonus-L3-C = {0}", employee9.calcBonus(4)));
        }
    }
}
