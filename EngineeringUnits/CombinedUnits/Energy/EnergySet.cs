﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Energy
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromSI(double si)
        {
            double value = (double)si;
            return new Energy(value, EnergyUnit.SI);
        }

        /// <summary>
        ///     Get Energy from BritishThermalUnits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromBritishThermalUnits(double britishthermalunits)
        {
            double value = (double)britishthermalunits;
            return new Energy(value, EnergyUnit.BritishThermalUnit);
        }
        /// <summary>
        ///     Get Energy from Calories.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromCalories(double calories)
        {
            double value = (double)calories;
            return new Energy(value, EnergyUnit.Calorie);
        }
        /// <summary>
        ///     Get Energy from DecathermsEc.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromDecathermsEc(double decathermsec)
        {
            double value = (double)decathermsec;
            return new Energy(value, EnergyUnit.DecathermEc);
        }
        /// <summary>
        ///     Get Energy from DecathermsImperial.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromDecathermsImperial(double decathermsimperial)
        {
            double value = (double)decathermsimperial;
            return new Energy(value, EnergyUnit.DecathermImperial);
        }
        /// <summary>
        ///     Get Energy from DecathermsUs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromDecathermsUs(double decathermsus)
        {
            double value = (double)decathermsus;
            return new Energy(value, EnergyUnit.DecathermUs);
        }
        /// <summary>
        ///     Get Energy from ElectronVolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromElectronVolts(double electronvolts)
        {
            double value = (double)electronvolts;
            return new Energy(value, EnergyUnit.ElectronVolt);
        }
        /// <summary>
        ///     Get Energy from Ergs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromErgs(double ergs)
        {
            double value = (double)ergs;
            return new Energy(value, EnergyUnit.Erg);
        }
        /// <summary>
        ///     Get Energy from FootPounds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromFootPounds(double footpounds)
        {
            double value = (double)footpounds;
            return new Energy(value, EnergyUnit.FootPound);
        }
        /// <summary>
        ///     Get Energy from GigabritishThermalUnits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromGigabritishThermalUnits(double gigabritishthermalunits)
        {
            double value = (double)gigabritishthermalunits;
            return new Energy(value, EnergyUnit.GigabritishThermalUnit);
        }
        /// <summary>
        ///     Get Energy from GigaelectronVolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromGigaelectronVolts(double gigaelectronvolts)
        {
            double value = (double)gigaelectronvolts;
            return new Energy(value, EnergyUnit.GigaelectronVolt);
        }
        /// <summary>
        ///     Get Energy from Gigajoules.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromGigajoules(double gigajoules)
        {
            double value = (double)gigajoules;
            return new Energy(value, EnergyUnit.Gigajoule);
        }
        /// <summary>
        ///     Get Energy from GigawattDays.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromGigawattDays(double gigawattdays)
        {
            double value = (double)gigawattdays;
            return new Energy(value, EnergyUnit.GigawattDay);
        }
        /// <summary>
        ///     Get Energy from GigawattHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromGigawattHours(double gigawatthours)
        {
            double value = (double)gigawatthours;
            return new Energy(value, EnergyUnit.GigawattHour);
        }
        /// <summary>
        ///     Get Energy from HorsepowerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromHorsepowerHours(double horsepowerhours)
        {
            double value = (double)horsepowerhours;
            return new Energy(value, EnergyUnit.HorsepowerHour);
        }
        /// <summary>
        ///     Get Energy from Joules.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromJoules(double joules)
        {
            double value = (double)joules;
            return new Energy(value, EnergyUnit.Joule);
        }
        /// <summary>
        ///     Get Energy from KilobritishThermalUnits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromKilobritishThermalUnits(double kilobritishthermalunits)
        {
            double value = (double)kilobritishthermalunits;
            return new Energy(value, EnergyUnit.KilobritishThermalUnit);
        }
        /// <summary>
        ///     Get Energy from Kilocalories.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromKilocalories(double kilocalories)
        {
            double value = (double)kilocalories;
            return new Energy(value, EnergyUnit.Kilocalorie);
        }
        /// <summary>
        ///     Get Energy from KiloelectronVolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromKiloelectronVolts(double kiloelectronvolts)
        {
            double value = (double)kiloelectronvolts;
            return new Energy(value, EnergyUnit.KiloelectronVolt);
        }
        /// <summary>
        ///     Get Energy from Kilojoules.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromKilojoules(double kilojoules)
        {
            double value = (double)kilojoules;
            return new Energy(value, EnergyUnit.Kilojoule);
        }
        /// <summary>
        ///     Get Energy from KilowattDays.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromKilowattDays(double kilowattdays)
        {
            double value = (double)kilowattdays;
            return new Energy(value, EnergyUnit.KilowattDay);
        }
        /// <summary>
        ///     Get Energy from KilowattHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromKilowattHours(double kilowatthours)
        {
            double value = (double)kilowatthours;
            return new Energy(value, EnergyUnit.KilowattHour);
        }
        /// <summary>
        ///     Get Energy from MegabritishThermalUnits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromMegabritishThermalUnits(double megabritishthermalunits)
        {
            double value = (double)megabritishthermalunits;
            return new Energy(value, EnergyUnit.MegabritishThermalUnit);
        }
        /// <summary>
        ///     Get Energy from Megacalories.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromMegacalories(double megacalories)
        {
            double value = (double)megacalories;
            return new Energy(value, EnergyUnit.Megacalorie);
        }
        /// <summary>
        ///     Get Energy from MegaelectronVolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromMegaelectronVolts(double megaelectronvolts)
        {
            double value = (double)megaelectronvolts;
            return new Energy(value, EnergyUnit.MegaelectronVolt);
        }
        /// <summary>
        ///     Get Energy from Megajoules.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromMegajoules(double megajoules)
        {
            double value = (double)megajoules;
            return new Energy(value, EnergyUnit.Megajoule);
        }
        /// <summary>
        ///     Get Energy from MegawattDays.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromMegawattDays(double megawattdays)
        {
            double value = (double)megawattdays;
            return new Energy(value, EnergyUnit.MegawattDay);
        }
        /// <summary>
        ///     Get Energy from MegawattHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromMegawattHours(double megawatthours)
        {
            double value = (double)megawatthours;
            return new Energy(value, EnergyUnit.MegawattHour);
        }
        /// <summary>
        ///     Get Energy from Millijoules.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromMillijoules(double millijoules)
        {
            double value = (double)millijoules;
            return new Energy(value, EnergyUnit.Millijoule);
        }
        /// <summary>
        ///     Get Energy from TeraelectronVolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromTeraelectronVolts(double teraelectronvolts)
        {
            double value = (double)teraelectronvolts;
            return new Energy(value, EnergyUnit.TeraelectronVolt);
        }
        /// <summary>
        ///     Get Energy from TerawattDays.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromTerawattDays(double terawattdays)
        {
            double value = (double)terawattdays;
            return new Energy(value, EnergyUnit.TerawattDay);
        }
        /// <summary>
        ///     Get Energy from TerawattHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromTerawattHours(double terawatthours)
        {
            double value = (double)terawatthours;
            return new Energy(value, EnergyUnit.TerawattHour);
        }
        /// <summary>
        ///     Get Energy from ThermsEc.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromThermsEc(double thermsec)
        {
            double value = (double)thermsec;
            return new Energy(value, EnergyUnit.ThermEc);
        }
        /// <summary>
        ///     Get Energy from ThermsImperial.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromThermsImperial(double thermsimperial)
        {
            double value = (double)thermsimperial;
            return new Energy(value, EnergyUnit.ThermImperial);
        }
        /// <summary>
        ///     Get Energy from ThermsUs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromThermsUs(double thermsus)
        {
            double value = (double)thermsus;
            return new Energy(value, EnergyUnit.ThermUs);
        }
        /// <summary>
        ///     Get Energy from WattDays.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromWattDays(double wattdays)
        {
            double value = (double)wattdays;
            return new Energy(value, EnergyUnit.WattDay);
        }
        /// <summary>
        ///     Get Energy from WattHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Energy FromWattHours(double watthours)
        {
            double value = (double)watthours;
            return new Energy(value, EnergyUnit.WattHour);
        }

    }
}
