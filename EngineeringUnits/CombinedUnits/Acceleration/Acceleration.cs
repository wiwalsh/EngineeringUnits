﻿using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Acceleration : BaseUnit
    {

        public Acceleration()
        {
            Unit = AccelerationUnit.SI.Unit.Copy();
        }

        public Acceleration(decimal value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(double value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(int value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Acceleration From(double value, AccelerationUnit unit) => new Acceleration(value, unit);
        public double As(AccelerationUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Acceleration ToUnit(AccelerationUnit selectedUnit) => new Acceleration(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Acceleration Zero => new Acceleration(0, AccelerationUnit.SI);

        public static implicit operator Acceleration(UnknownUnit Unit)
        {
            Acceleration local = new Acceleration(0, AccelerationUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
