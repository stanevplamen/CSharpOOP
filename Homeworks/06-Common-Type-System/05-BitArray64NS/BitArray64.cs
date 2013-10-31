using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitArray64NS
{
    public class BitArray64 : IEnumerable<int>
    {
        #region Fields

        public const int allBits = 64;
        private ulong bitValue;

        #endregion

        #region Properties

        public ulong BitValue
        {
            get
            {
                return this.bitValue;
            }
            private set
            {
                this.bitValue = value;
            }
        }

        // Indexer declaration
        public int this[int index]
        {
            get
            {
                if ((index >= 0) && (index < allBits))
                {

                    if ((bitValue & ((ulong)1 << index)) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format("Invalud Index: {0}!", index));
                }
            }

            set
            {
                if ((index < 0) || (index > allBits - 1))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalud Index: {0}!", index));
                }
                if ((value < 0) || (value > 1))
                {
                    throw new ArgumentOutOfRangeException(String.Format("Invalid Value: {0}!", value));
                }

                // Clear the bit at position index
                bitValue &= ~((ulong)((ulong)1 << index));

                // Set the bit at position index to value
                bitValue |= (ulong)((ulong)value << index);
            }
        }

        #endregion

        #region Constructors

        public BitArray64(ulong bitValue)
        {
            this.BitValue = bitValue;
        }

        public BitArray64()
        {
            this.BitValue = (ulong)0;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return "Bits = " + Convert.ToString((long)this.BitValue, 2).PadLeft(64, '0');
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // Call the generic version of the method
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < allBits; i++)
            {
                yield return this[i];
            }
        }

        public override bool Equals(object param)
        {
            BitArray64 bitarr = param as BitArray64;

            if (bitarr == null)
            {
                return false;
            }

            if (this.ToString() != bitarr.ToString())
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(BitArray64 bitarr1, BitArray64 bitarr2)
        {
            return BitArray64.Equals(bitarr1, bitarr2);
        }

        public static bool operator !=(BitArray64 bitarr1, BitArray64 bitarr2)
        {
            return !(BitArray64.Equals(bitarr1, bitarr2));
        }

        public override int GetHashCode()
        {
            return this.bitValue.GetHashCode();
        }

        #endregion
    }
}
