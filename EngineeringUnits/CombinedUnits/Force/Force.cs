﻿using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Force : BaseUnit
    {

        public Force()
        {
            Unit = ForceUnit.SI.Unit.Copy();
        }

        public Force(decimal value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Force(double value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Force(int value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Force From(double value, ForceUnit unit) => new Force(value, unit);
        public double As(ForceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Force ToUnit(ForceUnit selectedUnit) => new Force(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Force Zero => new Force(0, ForceUnit.SI);

        public static implicit operator Force(UnknownUnit Unit)
        {
            Force local = new Force(0, ForceUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
