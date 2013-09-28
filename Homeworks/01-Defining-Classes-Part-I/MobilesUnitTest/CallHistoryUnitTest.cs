using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobiles;
using Mobiles.Enums;

namespace MobilesUnitTest
{
    [TestClass]
    public class CallHistoryUnitTest
    {
        [TestMethod]
        public void TestHistory1()
        {
            Battery newInitializdBattery = new Battery("Li-ion BLC-3", 90, 20, BatteryType.LiIon);
            Display newInitializedDisplay = new Display(600, 720, 256);
            GSM firstGSM = new GSM("3310", "Nokia corp.", 540.00m, "Mobile shop", newInitializdBattery, newInitializedDisplay);

            firstGSM.AddCall(new DateTime(2013, 12, 30, 14, 30, 28), "0888 333444", 236);
            firstGSM.AddCall(new DateTime(2013, 12, 30, 15, 20, 48), "0888 555222", 454);
            firstGSM.AddCall(new DateTime(2013, 12, 30, 18, 40, 4), "0888 666777", 1010);

            decimal pricePerMinute = 0.37m;
            Console.WriteLine("The calls price is: {0:C2}", firstGSM.CalcTotalPrice(pricePerMinute));

            Assert.AreEqual(9.62m, firstGSM.CalcTotalPrice(pricePerMinute));
        }

        [TestMethod]
        public void TestHistory2()
        {
            GSM secondGSM = new GSM();

            secondGSM.AddCall(new DateTime(2013, 12, 30, 14, 30, 28), "0888 333444", 236);
            secondGSM.AddCall(new DateTime(2013, 12, 30, 15, 20, 48), "0888 555222", 454);
            secondGSM.AddCall(new DateTime(2013, 12, 30, 18, 40, 4), "0888 666777", 1010);

            decimal pricePerMinute = 0.37m;
            secondGSM.DeleteCall(1010l);

            Assert.AreEqual(3.70m, secondGSM.CalcTotalPrice(pricePerMinute));
        }    
    }
}
