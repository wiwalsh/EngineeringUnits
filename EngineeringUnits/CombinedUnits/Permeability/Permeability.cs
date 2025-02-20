﻿using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Permeability : BaseUnit
    {

        public Permeability()
        {
            Unit = PermeabilityUnit.SI.Unit.Copy();
        }

        public Permeability(decimal value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permeability(double value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permeability(int value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Permeability From(double value, PermeabilityUnit unit) => new Permeability(value, unit);
        public double As(PermeabilityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Permeability ToUnit(PermeabilityUnit selectedUnit) => new Permeability(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Permeability Zero => new Permeability(0, PermeabilityUnit.SI);

        public static implicit operator Permeability(UnknownUnit Unit)
        {
            Permeability local = new Permeability(0, PermeabilityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
