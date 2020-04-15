using Abc.Aids;
using Abc.Data.Quantity;

namespace Abc.Domain.Quantity
{
    public sealed class Quantity
    {
        private readonly Unit unit;
        public double Amount { get; }

        public Quantity() : this(0, null) { }

        public Quantity(double amount, Unit u)
        {
            Amount = amount;
            unit = u;
        }

        public Unit Unit
        {
            get
            {
                if (unit is null) return null;
                var d = new UnitData();
                Copy.Members(unit.Data, d);
                return new Unit(d);
            }
        }

        //public override string ToString() => $"{Amount}{GetCode()}";

        //private void GetCode()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Round()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
