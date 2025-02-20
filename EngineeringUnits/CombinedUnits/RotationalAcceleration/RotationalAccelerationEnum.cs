﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class RotationalAccelerationUnit : Enumeration
    {

        public static readonly RotationalAccelerationUnit SI = new RotationalAccelerationUnit(LengthUnit.SI);
        public static readonly RotationalAccelerationUnit CubicMeter = new RotationalAccelerationUnit(LengthUnit.Meter);
        public static readonly RotationalAccelerationUnit HectocubicMeter = new RotationalAccelerationUnit(PreFix.hecto, CubicMeter);
        public static readonly RotationalAccelerationUnit KilocubicMeter = new RotationalAccelerationUnit(PreFix.kilo, CubicMeter);



        public RotationalAccelerationUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RotationalAccelerationUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RotationalAccelerationUnit(PreFix SI, RotationalAccelerationUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RotationalAccelerationUnit(RotationalAccelerationUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}