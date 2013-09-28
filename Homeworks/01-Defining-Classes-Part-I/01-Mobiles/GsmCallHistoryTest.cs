using System;
using System.Collections.Generic;
using Mobiles.Enums;

namespace Mobiles
{
    class GsmCallHistoryTest
    {
        public static void OperateHistoryList()
        {
            Battery newBattery = new Battery("Li-ion BLC-4", 200, 40, BatteryType.LiIon);
            Display newDisplay = new Display(600, 920, 528);
            GSM newPhone = new GSM("3310 Tunning", "Nokia corp.", 540.00m, "Mobile shop", newBattery, newDisplay);

            newPhone.AddCall(new DateTime(2013, 12, 30, 14, 30, 28), "0888 333444", 236);
            newPhone.AddCall(new DateTime(2013, 12, 30, 15, 20, 48), "0888 555222", 454);
            newPhone.AddCall(new DateTime(2013, 12, 30, 18, 40, 4), "0888 666777", 1010);

            newPhone.DisplayCallHistory();

            decimal pricePerMinute = 0.37m;
            Console.WriteLine("The calls price is: {0:C2}", newPhone.CalcTotalPrice(pricePerMinute));

            newPhone.DeleteCall(1010l);
            newPhone.DisplayCallHistory();
            Console.WriteLine("The calls price is: {0:C2}", newPhone.CalcTotalPrice(pricePerMinute));

            newPhone.ClearCalls();
            newPhone.DisplayCallHistory();
        }
    }
}
