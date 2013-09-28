using System;
using System.Collections.Generic;
using Mobiles.Enums;
using Wintellect.PowerCollections;
using System.Text;

namespace Mobiles
{
    public class GSM
    {
        #region Fields

        public Battery battery = new Battery();
        public Display display = new Display();

        private string model;
        private string manufacturer;
        public decimal? price;
        public string owner;

        private MultiDictionary<long, Call> callHistory = new MultiDictionary<long, Call>(true);

        static public GSM iPhone = new GSM("iPhone 4S", "Apple corp.");

        #endregion

        #region Properties

        public static GSM Iphone
        {
            get
            {
                return iPhone;
            }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public decimal? Price
        {
            get { return price; }
            set
            {
                if ((value >= 1m && value < 20000m) || value == null)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        #endregion

        #region Constructors

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.Price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {

        }

        public GSM()
        {
            this.model = "5110";
            this.manufacturer = "Nokia corp.";
            this.price = null;
            this.owner = null;
            this.battery = new Battery();
            this.display = new Display();
        }

        #endregion

        #region Methods

        public void AddCall(DateTime callTime, string callNumber, int callDuration)
        {
            Call currentCall = new Call(callTime, callNumber, callDuration);
            callHistory.Add(callDuration, currentCall);
        }
        public void DeleteCall(long callDuration)
        {
            if (callHistory.ContainsKey(callDuration))
            {
                callHistory.Remove(callDuration);
            }
        }
        public void ClearCalls()
        {
            callHistory.Clear();
        }

        public decimal CalcTotalPrice(decimal costPerMinute)
        {
            decimal currentPrice = 0m;
            foreach (var pair in callHistory)
            {
                foreach (var call in pair.Value)
                {
                    decimal minutesCall = (decimal)(call.SecondsCalled / 60);
                    currentPrice = currentPrice + costPerMinute * minutesCall;
                }
            }
            return currentPrice;
        }

        public void PrintGSMDetails()
        {
            Console.WriteLine("Please see the following GSM:\nModel: {0}", model);
            Console.WriteLine("Manufacturer: {0}", manufacturer);
            Console.WriteLine("Price: {0:C2}", price);
            Console.WriteLine("Current owner: {0}", owner);
            try
            {
                Console.WriteLine("Battery: model-{0}, hours idle-{1}, hours talk-{2}, battery type-{3}", battery.ModelBat, battery.HoursIdle, battery.HoursTalk, battery.TypeBatt);
                Console.WriteLine("Display: width-{0}, heigth-{1}, colors-{2}", display.Width, display.Heigth, display.Colors);
            }
            catch (NullReferenceException e)
            {

            }
            Console.WriteLine("========================\n");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Please see the following GSM:\nModel: {0}\n", model);
            sb.AppendFormat("Manufacturer: {0}\n", manufacturer);
            sb.AppendFormat("Price: {0:C2}\n", price);
            sb.AppendFormat("Current owner: {0}\n", owner);
            try
            {
                sb.AppendFormat("Battery: model-{0}, hours idle-{1}, hours talk-{2}, battery type-{3}\n", battery.ModelBat, battery.HoursIdle, battery.HoursTalk, battery.TypeBatt);
                sb.AppendFormat("Display: width-{0}, heigth-{1}, colors-{2}\n", display.Width, display.Heigth, display.Colors);
            }
            catch (NullReferenceException e)
            {

            }
            sb.AppendLine("========================");
            return sb.ToString();
        }

        public void DisplayCallHistory()
        {
            if (callHistory.Count > 0)
            {
                StringBuilder callHist = new StringBuilder();
                callHist.AppendLine("CALL HISTORY:");
                foreach (var pair in callHistory)
                {
                    foreach (var call in pair.Value)
                    {
                        callHist.AppendFormat("Number: {0}, Date: {1}, Duration: {2} seconds \n", call.NumberCalled, call.TimeCalled, call.SecondsCalled);
                    }
                }
                Console.WriteLine(callHist.ToString());
            }
            else
            {
                Console.WriteLine("There are no calls in history");
            }
        }

        #endregion
    }
}
