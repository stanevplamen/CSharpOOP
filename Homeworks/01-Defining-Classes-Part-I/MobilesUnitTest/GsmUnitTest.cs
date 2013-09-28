using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobiles;
using Mobiles.Enums;

namespace MobilesUnitTest
{
    [TestClass]
    public class GsmUnitTest
    {
        [TestMethod]
        public void TestGsm1()
        {
            Battery newInitializdBattery = new Battery("Li-ion BLC-3", 90, 20, BatteryType.LiIon);
            Display newInitializedDisplay = new Display(600, 720, 256);
            GSM firstGSM = new GSM("3310", "Nokia corp.", 540.00m, "Mobile shop", newInitializdBattery, newInitializedDisplay);

            Assert.AreEqual("3310", firstGSM.Model);
            Assert.AreEqual("Nokia corp.", firstGSM.Manufacturer);
            Assert.AreEqual(540.00m, firstGSM.Price);
            Assert.AreEqual("Mobile shop", firstGSM.Owner);
            Assert.AreEqual(BatteryType.LiIon, firstGSM.battery.TypeBatt);
            Assert.AreEqual(256, firstGSM.display.Colors);          
        }

        [TestMethod]
        public void TestGsm2()
        {
            GSM secondGSM = new GSM();

            Assert.AreEqual("5110", secondGSM.Model);
            Assert.AreEqual("Nokia corp.", secondGSM.Manufacturer);
            Assert.AreEqual(null, secondGSM.Price);
            Assert.AreEqual(null, secondGSM.Owner);
            Assert.AreEqual(BatteryType.Null, secondGSM.battery.TypeBatt);
            Assert.AreEqual(null, secondGSM.display.Colors);
        }

        [TestMethod]
        public void TestGsm3()
        {
            GSM thirdGSM = new GSM("3410", "Nokia corp.");
            thirdGSM.battery = new Battery("Li-ion BLC-1", null, null, BatteryType.Null);
            thirdGSM.display = new Display(null, null, 256);

            Assert.AreEqual("3410", thirdGSM.Model);
            Assert.AreEqual("Nokia corp.", thirdGSM.Manufacturer);
            Assert.AreEqual(null, thirdGSM.Price);
            Assert.AreEqual(null, thirdGSM.Owner);
            Assert.AreEqual(BatteryType.Null, thirdGSM.battery.TypeBatt);
            Assert.AreEqual(256, thirdGSM.display.Colors);
        }
    }
}
