﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;
using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class LuminousIntensity : BaseUnit
    {

        public LuminousIntensity()
        {
            Unit = LuminousIntensityUnit.SI.Unit.Copy();
        }

        public LuminousIntensity(decimal value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousIntensity(double value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousIntensity(int value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static LuminousIntensity From(double value, LuminousIntensityUnit unit) => new LuminousIntensity(value, unit);
        public double As(LuminousIntensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public LuminousIntensity ToUnit(LuminousIntensityUnit selectedUnit) => new LuminousIntensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LuminousIntensity Zero => new LuminousIntensity(0, LuminousIntensityUnit.SI);

        public static implicit operator LuminousIntensity(UnknownUnit Unit)
        {
            LuminousIntensity local = new LuminousIntensity(0, LuminousIntensityUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
