using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryQuota.Application.Services.Exceptions
{
    public class QuotaException: Exception
    {
        
            public string Code { get; }

            public QuotaException(string code, string message) : base(message)
            {
                Code = code;
            }
        
    }
}
