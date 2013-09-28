using System;
using System.Collections.Generic;

namespace Mobiles
{
    public class Display
    {
        #region Fields

        private int? width;
        private int? heigth;
        private int? colors;

        #endregion

        #region Properties

        public int? Width
        {
            get { return width; }
            set
            {
                if ((value >= 10 && value < 99999) || value == null)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int? Heigth
        {
            get { return heigth; }
            set
            {
                if ((value >= 10 && value < 99999) || value == null)
                {
                    this.heigth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int? Colors
        {
            get { return colors; }
            set
            {
                if (value > 0 || value == null)
                {
                    this.colors = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        #endregion

        #region Constructors

        public Display(int? width, int? heigth, int? colors)
        {
            this.Width = width;
            this.Heigth = heigth;
            this.Colors = colors;
        }

        public Display()
            : this(null, null, null)
        {

        }

        #endregion
    }
}
