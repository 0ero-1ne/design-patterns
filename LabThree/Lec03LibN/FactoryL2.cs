namespace Lec03LibN
{
    public class FactoryL2 : IFactory
    {
        public float A { get; set; }

        public FactoryL2(float a)
        {
            A = a;
        }

        public IBonus getA(float cost1hour)
        {
            return new L2ABonus(cost1hour, A);
        }

        public IBonus getB(float cost1hour, float x)
        {
            return new L2BBonus(cost1hour, A, x);
        }

        public IBonus getC(float cost1hour, float x, float y)
        {
            return new L2CBonus(cost1hour, A, x, y);
        }
    }

    public class L2ABonus : IBonus
    {
        public float cost1hour { get; set; }
        public float A { get; set; }

        public L2ABonus(float cost1hour, float a)
        {
            this.cost1hour = cost1hour;
            A = a;
        }

        public float calc(float number_hours)
        {
            return (number_hours + A) * cost1hour;
        }
    }

    public class L2BBonus : IBonus
    {
        public float A { get; set; }
        public float X { get; set; }
        public float cost1hour { get; set; }

        public L2BBonus(float cost1hour, float a, float x)
        {
            this.cost1hour = cost1hour;
            X = x;
            A = a;
        }

        public float calc(float number_hours)
        {
            return (number_hours + A) * cost1hour * X;
        }
    }

    public class L2CBonus : IBonus
    {
        public float A { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float cost1hour { get; set; }

        public L2CBonus(float cost1hour, float a, float x, float y)
        {
            this.cost1hour = cost1hour;
            X = x;
            Y = y;
            A = a;
        }

        public float calc(float number_hours)
        {
            return (number_hours + A) * cost1hour * X + Y;
        }
    }
}
