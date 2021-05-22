using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Exceptions
{
    public class HttpResponseExceptionFilter : Microsoft.AspNetCore.Mvc.Filters.IActionFilter, IOrderedFilter
    {
        public int Order { get; } = int.MaxValue - 10;

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is HttpResponseException exception)
            {
                var responseCustomer = new
                {
                    userMsg = exception.Message,
                    Data = exception.Data
                };
                context.Result = new ObjectResult(responseCustomer)
                {
                    StatusCode = 400,
                };
                context.ExceptionHandled = true;
            }
        }
    }

}
