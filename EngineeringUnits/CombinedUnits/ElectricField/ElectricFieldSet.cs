﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricField
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricField FromSI(double si)
        {
            double value = (double)si;
            return new ElectricField(value, ElectricFieldUnit.SI);
        }

        /// <summary>
        ///     Get ElectricField from VoltsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricField FromVoltsPerMeter(double voltspermeter)
        {
            double value = (double)voltspermeter;
            return new ElectricField(value, ElectricFieldUnit.VoltPerMeter);
        }
    }
}
