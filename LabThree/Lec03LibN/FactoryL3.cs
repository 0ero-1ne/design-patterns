namespace Lec03LibN
{
    public class FactoryL3 : IFactory
    {
        public float A { get; set; }
        public float B { get; set; }

        public FactoryL3(float a, float b)
        {
            A = a;
            B = b;
        }

        public IBonus getA(float cost1hour)
        {
            return new L3ABonus(cost1hour, A, B);
        }

        public IBonus getB(float cost1hour, float x)
        {
            return new L3BBonus(cost1hour, A, B, x);
        }

        public IBonus getC(float cost1hour, float x, float y)
        {
            return new L3CBonus(cost1hour, A, B, x, y);
        }
    }

    public class L3ABonus : IBonus
    {
        public float A { get; set; }
        public float B { get; set; }
        public float cost1hour { get; set; }

        public L3ABonus(float cost1hour, float a, float b)
        {
            this.cost1hour = cost1hour;
            A = a;
            B = b;
        }

        public float calc(float number_hours)
        {
            return (number_hours + A) * (cost1hour + B);
        }
    }

    public class L3BBonus : IBonus
    {
        public float A { get; set; }
        public float B { get; set; }
        public float X { get; set; }
        public float cost1hour { get; set; }

        public L3BBonus(float cost1hour, float a, float b, float x)
        {
            this.cost1hour = cost1hour;
            X = x;
            A = a;
            B = b;
        }

        public float calc(float number_hours)
        {
            return (number_hours + A) * (cost1hour + B) * X;
        }
    }

    public class L3CBonus : IBonus
    {
        public float A { get; set; }
        public float B { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float cost1hour { get; set; }

        public L3CBonus(float cost1hour, float a, float b, float x, float y)
        {
            this.cost1hour = cost1hour;
            X = x;
            Y = y;
            A = a;
            B = b;
        }

        public float calc(float number_hours)
        {
            return (number_hours + A) * (cost1hour + B) * X + Y;
        }
    }
}
