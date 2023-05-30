namespace LabTwo
{
    class C4 : C3
    {
        public int PropertyThree { get; set; }

        public C4() { }

        public C4(int propertyThree)
        {
            PropertyThree = propertyThree;
        }

        public C4(int propertyOne, int propertyTwo, int propertyThree) : base(propertyOne, propertyTwo)
        {
            PropertyThree = propertyThree;
        }

        public int GetSum(int a, int b) => Sum(a, b);
    }
}