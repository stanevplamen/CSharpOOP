using System;
using System.Collections.Generic;

namespace Mobiles
{
    class Call
    {
        #region Fields

        private DateTime? timeCalled;
        private string numberCalled;
        private long? secondsCalled;

        #endregion

        #region Properties

        public DateTime? TimeCalled
        {
            get { return timeCalled; }
            set { this.timeCalled = value; }
        }

        public string NumberCalled
        {
            get { return numberCalled; }
            set { this.numberCalled = value; }
        }

        public long? SecondsCalled
        {
            get { return secondsCalled; }
            set { this.secondsCalled = value; }
        }

        #endregion

        #region Constructors

        public Call(DateTime? timeCalled, string numberCalled, long? secondsCalled)
        {
            this.TimeCalled = timeCalled;
            this.NumberCalled = numberCalled;
            this.secondsCalled = secondsCalled;
        }

        public Call()
            : this(null, null, null)
        {

        }

        #endregion
    }
}
