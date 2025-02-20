﻿using EngineeringUnits.Units;
using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Torque : BaseUnit
    {

        public Torque()
        {
            Unit = TorqueUnit.SI.Unit.Copy();
        }

        public Torque(decimal value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Torque(double value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Torque(int value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Torque From(double value, TorqueUnit unit) => new Torque(value, unit);
        public double As(TorqueUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Torque ToUnit(TorqueUnit selectedUnit) => new Torque(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Torque Zero => new Torque(0, TorqueUnit.SI);

        public static implicit operator Torque(UnknownUnit Unit)
        {
            Torque local = new Torque(0, TorqueUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
