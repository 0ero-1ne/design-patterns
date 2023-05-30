namespace LabTwo
{
    delegate void PrintMessage(string message);

    class Program
    {
        public static void Main()
        {
            C1 c1 = new C1(1, 2, 3);
            Console.WriteLine(c1.GetPropertyThree());
            c1.PropertyThree = 4;
            Console.WriteLine(c1.fieldThree);
            Console.WriteLine(c1.GetPropertyThree());
            c1.fieldThree = 6;
            Console.WriteLine(c1.fieldThree + "\n\n");

            C1 c2 = new C1(c1);
            Console.WriteLine(c2.GetFieldThree() + "\n\n");

            C2 c3 = new C2();
            Console.WriteLine(c3.Sum(1, 2) + "\n\n");
            c3.Messaged += (string message) => Console.WriteLine(message);

            C4 c4 = new C4(1, 2, 3);
            Console.WriteLine(c4.PropertyThree);
            Console.WriteLine(c4.GetSum(1, 5));
        }
    }
}