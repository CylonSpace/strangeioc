﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strange.extensions.signal.impl
{
	public class SignalException : Exception
	{

        public SignalExceptionType type { get; set; }
        public SignalException() : base()
        {
        }

        /// Constructs a SignalException with a message and SignalExceptionType
		public SignalException(string message, SignalExceptionType exceptionType) : base(message)
		{
			type = exceptionType;
		}


	}
}

