namespace Lec03LibN
{
    public class FactoryL1 : IFactory
    {
        public IBonus getA(float cost1hour)
        {
            return new L1ABonus(cost1hour);
        }

        public IBonus getB(float cost1hour, float x)
        {
            return new L1BBonus(cost1hour, x);
        }

        public IBonus getC(float cost1hour, float x, float y)
        {
            return new L1CBonus(cost1hour, x, y);
        }
    }

    public class L1ABonus : IBonus
    {
        public float cost1hour { get; set; }

        public L1ABonus(float cost1hour)
        {
            this.cost1hour = cost1hour;
        }

        public float calc(float number_hours)
        {
            return number_hours * cost1hour;
        }
    }

    public class L1BBonus : IBonus
    {
        public float X { get; set; }
        public float cost1hour { get; set; }

        public L1BBonus(float cost1hour, float x)
        {
            this.cost1hour = cost1hour;
            X = x;
        }

        public float calc(float number_hours)
        {
            return number_hours * cost1hour * X;
        }
    }

    public class L1CBonus : IBonus
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float cost1hour { get; set; }

        public L1CBonus(float cost1hour, float x, float y)
        {
            this.cost1hour = cost1hour;
            X = x;
            Y = y;
        }

        public float calc(float number_hours)
        {
            return number_hours * cost1hour * X + Y;
        }
    }
}
