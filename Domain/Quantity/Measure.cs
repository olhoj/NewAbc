using Abc.Data.Quantity;
using Abc.Domain.Common;
using System.Collections.Generic;

namespace Abc.Domain.Quantity
{
    public sealed class Measure : Entity<MeasureData>
    {
        public Measure() : this(null) { }
        public Measure(MeasureData data, List<MeasureTerm> terms = null) : base(data) { }
    }
}
