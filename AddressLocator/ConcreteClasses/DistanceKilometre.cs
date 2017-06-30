using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    class DistanceKilometre : Distance
    {
        public override double ValueToMetresRatio => 1000;

        public override string Name => "Kilometre";

        public override string Abbreviation => "km";
    }
}
