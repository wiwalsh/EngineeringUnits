using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class SpeedTest
    {
        [TestMethod]
        public void SpeedSimple()
        {
            Length L1 = new Length(100, LengthUnit.Meter);
            Duration D1 = new Duration(10, DurationUnit.Second);

            string jsonString = JsonConvert.SerializeObject(L1);
            Length L1JSON = JsonConvert.DeserializeObject<Length>(jsonString);

            string jsonString2 = JsonConvert.SerializeObject(D1);
            Length D1JSON = JsonConvert.DeserializeObject<Length>(jsonString2);

            Speed S1 = L1JSON / D1JSON;

            string jsonString3 = JsonConvert.SerializeObject(S1);
            Speed S1JSON = JsonConvert.DeserializeObject<Speed>(jsonString3);


            Assert.AreEqual(10, (double)S1JSON.As(SpeedUnit.MeterPerSecond));
            Assert.AreEqual(36, (double)S1JSON.As(SpeedUnit.KilometerPerhour));
            Assert.AreEqual(10.936132983377078, (double)S1JSON.As(SpeedUnit.YardPerSecond));
        }


        [TestMethod]
        public void SpeedSimple2()
        {
            Length L1 = new Length(100, LengthUnit.Yard);
            Duration D1 = new Duration(10, DurationUnit.Hour);

            Speed S1 = L1 / D1;


            Assert.AreEqual(0.00254, (double)S1.As(SpeedUnit.MeterPerSecond));
            Assert.AreEqual(0.009144, (double)S1.As(SpeedUnit.KilometerPerhour));
            Assert.AreEqual(0.002777777777777778, (double)S1.As(SpeedUnit.YardPerSecond));
            Assert.AreEqual(0.1, (double)S1.As(SpeedUnit.InchPerSecond));
        }


    }
}
