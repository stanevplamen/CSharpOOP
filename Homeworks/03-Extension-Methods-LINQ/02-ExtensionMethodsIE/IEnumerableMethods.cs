using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodsIE
{
    public static class IEnumerableMethods 
    {
        public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
        {
            if (input == null)
            {
                throw new ArgumentNullException("The input cannot be null");
            }

            T sum = default(T);

            foreach (T item in input)
            {
                sum = (dynamic)sum + item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> input) where T : IComparable
        {
            if (input == null)
            {
                throw new ArgumentNullException("The input cannot be null");
            }

            dynamic product = 1;

            foreach (var numb in input)
            {
                product *= numb;
            }

            return product;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            var tempList = new List<T>();
            foreach (var numb in input)
            {
                tempList.Add(numb);
            }

            tempList.Sort();

            return tempList[tempList.Count - 1];
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            var tempList = new List<T>();
            foreach (var numb in input)
            {
                tempList.Add(numb);
            }

            tempList.Sort();

            return tempList[0];
        }

        public static T Average<T>(this IEnumerable<T> input) where T : IComparable
        {
            if (input == null)
            {
                throw new ArgumentNullException("The input cannot be null");
            }
            if (input.Count() == 0)
            {
                throw new InvalidOperationException("The collection must contain at least one element");
            }

            T sum = default(T);

            foreach (T item in input)
            {
                sum = (dynamic)sum + item;
            }

            return (dynamic)sum / input.Count();

        }
    }
}
