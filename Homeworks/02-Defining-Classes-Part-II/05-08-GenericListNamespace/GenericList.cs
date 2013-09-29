using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericListNamespace
{
    public class GenericList<T>
    {
        #region Fields

        private T[] elements;

        private int length;

        private readonly static T[] emptyArray;

        private const int defaultCapacity = 8;

        #endregion

        #region Properties

        public int Capacity
        {
            get
            {
                return (int)this.elements.Length;
            }
            set
            {              
                T[] tArray = new T[value];
                if (this.length > 0)
                {
                    Array.Copy(this.elements, 0, tArray, 0, this.length);
                }
                this.elements = tArray;                                 
            }
        }

        public int Count
        {
            get
            {
                return this.length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= elements.Length)
                {
                    throw new ArgumentOutOfRangeException(String.Format("Invalid index assignment: {0}.", index));
                }
                T result = this.elements[index];
                return result;
            }
            set
            {
                if (index < 0 || index >= elements.Length)
                {
                    throw new ArgumentOutOfRangeException(String.Format("Invalid index assignment: {0}.", index));
                }
                this.elements[index] = value;
            }
        }

        #endregion

        #region Constructors

        static GenericList()
        {
            GenericList<T>.emptyArray = new T[defaultCapacity];
        }

        public GenericList()
        {
            this.elements = GenericList<T>.emptyArray;
        }

        public GenericList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid list capacity");
            }
            else 
            {
                this.elements = new T[capacity];
            }
        }

        #endregion

        #region Public Methods

        public void Add(T item)
        {
            if (this.length == (int)this.elements.Length)
            {
                ExtendCapacity();
            }

            this.elements[this.length] = item;
            this.length++;
        }

        public void InsertAt(T item, int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(String.Format("Invalid index assignment: {0}.", index));
            }
            if (index >= (int)this.elements.Length)
            {
                ExtendCapacity(index, elements, length);
                this.elements[index] = item;
            }
            else
            {
                ExtendCapacity(this.elements.Length, elements, length);
                elements[index] = item;
            }
            this.length++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(String.Format("Invalid index assignment: {0}.", index));
            }

            if (index < this.length)
            {
                Array.Copy(this.elements, index + 1, this.elements, index, this.length - index);
                this.length--;
            }
        }

        public void Clear()
        {
            Array.Clear(this.elements, 0, this.length); 
            this.length = 0;
        }

        public int FindElement(int startIndex, dynamic item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item value can not be null.");
            }
            int indexToReturn = -1;
            for (int i = startIndex; i < elements.Length; i++)
            {
                if (item == elements[i])
                {
                    indexToReturn = i;
                    break;
                }
            }
            return indexToReturn;
        }

        public override string ToString()
        {
            StringBuilder resultSB = new StringBuilder();
            resultSB.Append("{");
            for (int i = 0; i < length; i++)
            {
                resultSB.Append(elements[i] + ", ");
            }
            resultSB.Append("\b\b}");
            return resultSB.ToString();
        }

        public T Min<T>() where T : IComparable<T>, IComparable
        {
            dynamic min = elements.Min();
            return min;
        }

        public T Max<T>() where T : IComparable<T>, IComparable
        {
            dynamic max = elements.Max();
            return max;
        }

        #endregion

        #region Private Methods

        private void ExtendCapacity()
        {
            this.Capacity = (int)this.elements.Length * 2;
        }

        private void ExtendCapacity(int index, T[] elements, int length)
        {
            T[] newArr = new T[Math.Max(elements.Length, index) + 1];
            if (index < elements.Length)
            {
                Array.Copy(elements, newArr, index);
                Array.Copy(elements, index, newArr, index + 1, elements.Length - index);
                this.length = Math.Max(index, length);
            }
            else
            {
                Array.Copy(elements, newArr, elements.Length);
                this.length = index;
            }
            this.elements = newArr; 
        }

        #endregion
    }
}
