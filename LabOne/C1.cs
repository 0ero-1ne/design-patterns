namespace LabTwo
{
    class C1
    {
        private const int constOne = 101;
        protected const int constTwo = 102;
        public const int constThree = 103;

        private int fieldOne = 104;
        protected int fieldTwo = 105;
        public int fieldThree = 106;

        private int PropertyOne { get; set; }
        protected int PropertyTwo { get; set; }
        public int PropertyThree { get; set; }

        public C1() {}

        public C1(C1 obj)
        {
            fieldOne = obj.fieldOne;
            fieldTwo = obj.fieldTwo;
            fieldThree = obj.fieldThree;
        }

        public C1(int fieldOne, int fieldTwo, int fieldThree)
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
    }
}