using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.Responses
{
    public class BaseCommandResponse
    {
        public int  Id { get; set; }
        public bool Success { get; set; }
        public string Messages { get; set; }
        public List<string>Errors { get; set; }
    }
}
