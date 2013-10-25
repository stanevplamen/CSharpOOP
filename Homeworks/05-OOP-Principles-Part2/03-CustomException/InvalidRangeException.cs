using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        #region Private Fields

        private T start;
        private T end;

        #endregion

        #region Properties

        public T Start
        {
            get
            {
                return start;
            }
        }

        public T End
        {
            get
            {
                return end;
            }
        }

        #endregion

        #region Constructors

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
        }

        public InvalidRangeException(string message, T start, T end, Exception causeException)
            : base(message, causeException)
        {
            this.start = start;
            this.end = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {
        }

        #endregion
    }
}
