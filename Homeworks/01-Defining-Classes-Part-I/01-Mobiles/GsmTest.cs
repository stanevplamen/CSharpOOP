using System;
using System.Collections.Generic;
using Mobiles.Enums;

namespace Mobiles
{
    class GsmTest
    {
        static void Main()
        {
            #region Gsm Test

            GSM[] mobiles = new GSM[5];

            Battery newInitializdBattery = new Battery("Li-ion BLC-3", 90, 20, BatteryType.LiIon);
            Display newInitializedDisplay = new Display(600, 720, 256);
            mobiles[0] = new GSM("3310", "Nokia corp.", 540.00m, "Mobile shop", newInitializdBattery, newInitializedDisplay);
            mobiles[0].PrintGSMDetails();

            mobiles[1] = new GSM();
            mobiles[1].price = 200.21m;
            Console.WriteLine(mobiles[1].ToString());

            mobiles[2] = new GSM("3410", "Nokia corp.");
            mobiles[2].battery = new Battery("Li-ion BLC-1", null, null, BatteryType.Null);
            Console.WriteLine(mobiles[2].ToString());

            Battery justModelOfBatt = new Battery("Li-ion BLC-3", null, null, BatteryType.NiMH);
            Display justColorsOfDisplay = new Display(null, null, 256);
            mobiles[3] = new GSM("6210", "Nokia corp.", null, null, justModelOfBatt, justColorsOfDisplay);
            Console.WriteLine(mobiles[3].ToString());

            Battery newIphoneBattery = new Battery("Li-Po 1432 mAh", 80, 30, BatteryType.LiIon);
            Display newIphoneDisplay = new Display(560, 840, 526);
            GSM.iPhone.price = 840.00m;
            GSM.iPhone.owner = "Mobile shop";
            GSM.iPhone.battery = newIphoneBattery;
            GSM.iPhone.display = newIphoneDisplay;
            mobiles[4] = GSM.iPhone;
            Console.WriteLine(mobiles[4].ToString());

            #endregion

            #region Call History Test

            GsmCallHistoryTest.OperateHistoryList();

            #endregion
        }
    }
}
