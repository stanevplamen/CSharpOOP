using System;
using System.Collections.Generic;
using Mobiles.Enums;

namespace Mobiles
{
    public class Battery
    {
        #region Fields

        private string modelBat;
        private float? hoursIdle;
        private float? hoursTalk;
        private BatteryType typeBatt;

        #endregion

        #region Properties

        public string ModelBat
        {
            get { return this.modelBat; }
            set
            {
                if ((value != null && value.Length >= 2) || value == null)
                {
                    this.modelBat = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

        public float? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if ((value >= 0 && value < 200000) || value == null)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public float? HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if ((value >= 0 && value < 20000) || value == null)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public BatteryType TypeBatt
        {
            get { return typeBatt; }
            set { typeBatt = value; }
        }

        #endregion

        #region Constructors

        public Battery(string modelBat, float? hoursIdle, float? hoursTalk, BatteryType typeBatt)
        {
            this.ModelBat = modelBat;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.TypeBatt = typeBatt;
        }

        public Battery()
            : this(null, null, null, BatteryType.Null)
        {
        }

        #endregion
    }     
}
