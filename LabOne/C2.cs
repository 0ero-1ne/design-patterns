namespace LabTwo
{
    class C2 : I1
    {
        public event PrintMessage Messaged;
        
        public string this [int index]
        {
            get => strings[index];
            set => strings[index] = value;
        }

        List<string> strings = new List<string>();

        private const int constOne = 101;
        protected const int constTwo = 102;
        public const int constThree = 103;

        private int fieldOne = 104;
        protected int fieldTwo = 105;
        public int fieldThree = 106;

        private int PropertyOne { get; set; }
        protected int PropertyTwo { get; set; }
        public int PropertyThree { get; set; }
        public int PropertyI1 { get; set; }

        public C2() {}

        public C2(C2 obj)
        {
            fieldOne = obj.fieldOne;
            fieldTwo = obj.fieldTwo;
            fieldThree = obj.fieldThree;
        }

        public C2(int fieldOne, int fieldTwo, int fieldThree)
        {
            this.fieldOne = fieldOne;
            this.fieldTwo = fieldTwo;
            this.fieldThree = fieldThree;
        }

        private int GetFieldOne() => fieldOne;
        private int GetPropertyOne() => PropertyOne;

        protected int GetFieldTwo() => fieldTwo;
        protected int GetPropertyTwo() => PropertyTwo;

        public int GetFieldThree() => fieldThree;
        public int GetPropertyThree() => PropertyThree;

        public int Sum(int a, int b) => a + b;
    }
}