﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class AreaDensityUnit : Enumeration
    {

        public static readonly AreaDensityUnit SI = new AreaDensityUnit(MassUnit.SI, AreaUnit.SI);
        public static readonly AreaDensityUnit KilogramPerSquareMeter = new AreaDensityUnit(MassUnit.Kilogram, AreaUnit.SquareMeter);




        public AreaDensityUnit(MassUnit mass, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / area;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public AreaDensityUnit(PreFix SI, AreaDensityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public AreaDensityUnit(AreaDensityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}