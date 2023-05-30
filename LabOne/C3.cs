namespace LabTwo
{
    class C3
    {
        private int PropertyOne { get; set; }
        protected int PropertyTwo { get; set; }

        public C3() {}

        public C3(C3 obj)
        {
            PropertyOne = obj.PropertyOne;
            PropertyTwo = obj.PropertyTwo;
        }

        public C3(int propertyOne, int propertyTwo)
        {
            PropertyOne = propertyOne;
            PropertyTwo = propertyTwo;
        }

        private float Sum(float a, float b) => a + b;
        protected int Sum(int a, int b) => a + b; 
    }
}