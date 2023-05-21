using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.Exception
{
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string message) : base(message)
        {
        }
    }
}
