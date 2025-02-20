﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class RotationalSpeedUnit : Enumeration
    {

        public static readonly RotationalSpeedUnit SI = new RotationalSpeedUnit(LengthUnit.SI);
        public static readonly RotationalSpeedUnit CubicMeter = new RotationalSpeedUnit(LengthUnit.Meter);
        public static readonly RotationalSpeedUnit HectocubicMeter = new RotationalSpeedUnit(PreFix.hecto, CubicMeter);
        public static readonly RotationalSpeedUnit KilocubicMeter = new RotationalSpeedUnit(PreFix.kilo, CubicMeter);



        public RotationalSpeedUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RotationalSpeedUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RotationalSpeedUnit(PreFix SI, RotationalSpeedUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RotationalSpeedUnit(RotationalSpeedUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}