﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.exception
{
    public class DaoException : Exception
    {
        public DaoException()
        {
        }

        public DaoException(string? message) : base(message)
        {
        }

        public DaoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DaoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
