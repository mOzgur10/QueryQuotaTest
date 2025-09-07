using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace QueryQuota.Application.Services.Exceptions
{
    public class QuotaExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is QuotaException quotaEx)
            {
                context.Result = new ObjectResult(new
                {
                    code = quotaEx.Code,
                    message = quotaEx.Message
                })
                {
                    StatusCode = StatusCodes.Status429TooManyRequests
                };

                context.ExceptionHandled = true;
            }
        }
    }
}
