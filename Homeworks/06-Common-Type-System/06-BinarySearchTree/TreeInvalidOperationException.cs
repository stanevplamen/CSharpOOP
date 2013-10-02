using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class TreeInvalidOperationException : ApplicationException
    {
        public TreeInvalidOperationException()
            : base()
        {
        }

        public TreeInvalidOperationException(string message, Exception insideEx)
            : base(message, insideEx)
        {
        }

        public TreeInvalidOperationException(string message)
            : this(message, null)
        {
        }
    }
}
