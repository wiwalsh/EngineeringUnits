﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;
using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class ElectricCurrent : BaseUnit
    {

        public ElectricCurrent()
        {
            Unit = ElectricCurrentUnit.SI.Unit.Copy();
        }

        public ElectricCurrent(decimal value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrent(double value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrent(int value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricCurrent From(double value, ElectricCurrentUnit unit) => new ElectricCurrent(value, unit);
        public double As(ElectricCurrentUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricCurrent ToUnit(ElectricCurrentUnit selectedUnit) => new ElectricCurrent(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrent Zero => new ElectricCurrent(0, ElectricCurrentUnit.SI);

        public static implicit operator ElectricCurrent(UnknownUnit Unit)
        {
            ElectricCurrent local = new ElectricCurrent(0, ElectricCurrentUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
