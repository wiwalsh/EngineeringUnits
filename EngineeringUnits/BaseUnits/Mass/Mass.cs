﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;
using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class Mass : BaseUnit
    {

        public Mass()
        {
            Unit = MassUnit.SI.Unit.Copy();
        }


        public Mass(decimal value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Mass(double value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Mass(int value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Mass From(double value, MassUnit unit) => new Mass(value, unit);
        public double As(MassUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Mass ToUnit(MassUnit selectedUnit) => new Mass(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Mass Zero => new Mass(0, MassUnit.SI);

        public static implicit operator Mass(UnknownUnit Unit)
        {
            Mass local = new Mass(0, MassUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
