using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class TemperatureTest
    {


        [TestMethod]
        public void TemperatureEqual()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(20, TemperatureUnit.DegreeCelsius);

            Assert.AreEqual(T1, T2);


        }

        [TestMethod]
        public void TemperatureNotEqual()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(21, TemperatureUnit.DegreeCelsius);

            Assert.AreNotEqual(T1, T2);


        }



        [TestMethod]
        public void TemperatureCelsiusDivideDouble()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);


            T1 /= 10;

            Assert.AreEqual(-243.835, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(29.315, T1.As(TemperatureUnit.Kelvin));

        }


        [TestMethod]
        public void TemperatureCelsiusTimesDouble()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);


            T1 *= 10;

            Assert.AreEqual(2658.35, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(2931.5, T1.As(TemperatureUnit.Kelvin));

        }


        [TestMethod]
        public void TemperatureKelvinTimesDouble()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.Kelvin);


            T1 *= 10;

            Assert.AreEqual(200, T1.As(TemperatureUnit.Kelvin));

        }




        [TestMethod]
        public void TemperatureConvertsFromKelvin()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.Kelvin);


            Assert.AreEqual(-423.67, (double)T1.As(TemperatureUnit.DegreeFahrenheit),0.00000001);            
            Assert.AreEqual(20, T1.As(TemperatureUnit.Kelvin));
            Assert.AreEqual(-253.15, T1.As(TemperatureUnit.DegreeCelsius));
        }


        [TestMethod]
        public void TemperatureConvertsFromCelsius()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);

            Debug.Print($"{T1}");

            Assert.AreEqual(293.15, T1.As(TemperatureUnit.Kelvin));
            Assert.AreEqual(20, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(68, (double)T1.As(TemperatureUnit.DegreeFahrenheit), 0.000001);
        }

        [TestMethod]
        public void TemperatureConvertsFromCelsiusJSON()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);

            string jsonstring = JsonConvert.SerializeObject(T1);
            Temperature JSON = JsonConvert.DeserializeObject<Temperature>(jsonstring);



            Assert.AreEqual(293.15, JSON.As(TemperatureUnit.Kelvin));
            Assert.AreEqual(20, JSON.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(68, (double)JSON.As(TemperatureUnit.DegreeFahrenheit), 0.000001);
        }


        [TestMethod]
        public void TemperatureConvertsFromFahrenheit()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeFahrenheit);


            Assert.AreEqual(266.48333333333335, (double)T1.As(TemperatureUnit.Kelvin), 0.0000001);
            Assert.AreEqual(-6.666667, (double)T1.As(TemperatureUnit.DegreeCelsius),0.00001);
            Assert.AreEqual(20, T1.As(TemperatureUnit.DegreeFahrenheit));
        }


        [TestMethod]
        public void TemperatureAdd()
        {

            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(293.15, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(68, TemperatureUnit.DegreeFahrenheit);



            //Debug.WriteLine($"{T1}");
            Temperature T4 = T1 + T1;
            Temperature T5 = T2 + T2;
            Temperature T6 = T3 + T3;


            Assert.AreEqual(586.3, (double)T4.As(TemperatureUnit.Kelvin), 0.0000001);
            Assert.AreEqual(313.15, (double)T5.As(TemperatureUnit.DegreeCelsius), 0.00001);
            Assert.AreEqual(595.67, (double)T6.As(TemperatureUnit.DegreeFahrenheit));
        }

        [TestMethod]
        public void TemperatureAdd2()
        {

            Temperature T1 = new Temperature(0, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(0, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(0, TemperatureUnit.DegreeFahrenheit);



            //Debug.WriteLine($"{T1}");
            Temperature T4 = T1 + T1;
            Temperature T5 = T2 + T2;
            Temperature T6 = T3 + T3;


            Assert.AreEqual(546.3, (double)T4.As(TemperatureUnit.Kelvin), 0.0000001);
            Assert.AreEqual(0, (double)T5.As(TemperatureUnit.Kelvin), 0.00001);
            Assert.AreEqual(510.7444444444444, (double)T6.As(TemperatureUnit.Kelvin));
        }

        [TestMethod]
        public void TemperatureMultiply()
        {

            Temperature T1 = new Temperature(0, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(0, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(0, TemperatureUnit.DegreeFahrenheit);


            var T4 = T1 * T1;
            var T5 = T2 * T2;
            var T6 = T3 * T3;


            //Assert.AreEqual("74337,7725 �C�", T4.ToString());
            Assert.AreEqual("0 K�", T5.ToString());
            //Assert.AreEqual("116927,27938888899 �F�", T6.ToString());
        }


        [TestMethod]
        public void TemperatureDivideTemperature()
        {

            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(293.15, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(68, TemperatureUnit.DegreeFahrenheit);



            //Debug.WriteLine($"{T1}");
            double T4 = (double)(T1 / T1);
            double T5 = (double)(T2 / T2);
            double T6 = (double)(T3 / T3);

            double T7 = (double)(T2 / T1);
            double T8 = (double)(T3 / T2);
            double T9 = (double)(T1 / T3);


            Assert.AreEqual(1, T4, 0);
            Assert.AreEqual(1, T5, 0);
            Assert.AreEqual(1, T6, 0);

            Assert.AreEqual(1, T7, 0);
            Assert.AreEqual(1, T8, 0);
            Assert.AreEqual(1, T9, 0);

        }

        [TestMethod]
        public void TemperatureDivideTemperature2()
        {

            Temperature T1 = new Temperature(10, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(10, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(10, TemperatureUnit.DegreeFahrenheit);



            double T7 = (double)(T2 / T1);
            double T8 = (double)(T3 / T2);
            double T9 = (double)(T1 / T3);
            double T10 = (double)(T3 / T1);

            Assert.AreEqual(0.035316969803990815, T7);
            Assert.AreEqual(26.092777777777776, T8);
            Assert.AreEqual(1.0851661805097197, T9);
            Assert.AreEqual(0.9215178448800204, T10);

        }
    }
}
